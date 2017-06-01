Shader "Custom/Test/ShaderTest_TEX-COL1" 
{

	//variables
	Properties 
	{
		_MainTexture ("Texture", 2D) = "white" {}
		_Color ("Colour", Color) = (1,1,1,1)
	}

	//Use SubShader for different target platforms, 
	//such as PS4, iPhone, Android, low end mobile, etc.,
	//allows to seperate shader functions and values for different targets
	SubShader 
	{

		//take data and draw to screen, 
		//can have multiple 'Pass' but requires more power
		Pass 
		{

			CGPROGRAM

			//Define vertex and fragment functions
			#pragma vertex vertexFunction
			#pragma fragment fragmentFunction

			//Call library
			#include "UnityCG.cginc"

			//Get data/import the vertices for the object
			//storing data within a shader 
			//'data format | custom name of data : variable type'
			//float4 = 4 values, POS = xyzw - 1,1,1,1
			//float2 = 2 values, UV = xy - 1,1
			struct appdata
			{
				float4 vertex : POSITION;
				float2 uv : TEXCOORD0;
			};

			//return position _to screen via v2f
			//v2f - vertex to fragment function
			struct v2f 
			{
				float4 position : SV_POSITION;
				float2 uv :TEXCOORD0;
			};

			float4 _Color;
			sampler2D _MainTexture;


			//Vertex - Build the object
			//Get the positions of the vertices then pass to the screen
			//MVP - Model View Projection (data from camera)
			v2f vertexFunction(appdata IN)
			{
				v2f OUT;

				OUT.position = mul(UNITY_MATRIX_MVP, IN.vertex);
				OUT.uv = IN.uv;

				return OUT;
			}


			//Fragment - Colours it in/draws pixels to screen
			fixed4 fragmentFunction(v2f IN) : SV_Target 
			{
				float4 textureColor = tex2D(_MainTexture, IN.uv);

				return textureColor * _Color;
			}


			ENDCG
		}
	}
}