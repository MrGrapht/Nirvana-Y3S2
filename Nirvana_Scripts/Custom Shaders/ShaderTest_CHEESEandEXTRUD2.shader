﻿Shader "Custom/Test/ShaderTest_CHEESEandEXTRUD2" 
{

	//variables
	Properties 
	{
		_MainTexture ("Texture", 2D) = "white" {}
		_Color ("Colour", Color) = (1,1,1,1)

		_DissolveTexture("Cheese", 2D) = "white" {}
		_DissolveAmount("Cheese Cut Out Amount", float) = 1

		_ExtrudeAmount("Extrude Amount", Range(-1, 1)) = 1
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
			//float 3 = 3 values, NORM = xyz - 1,1,1
			struct appdata
			{
				float4 vertex : POSITION;
				float2 uv : TEXCOORD0;
				float3 normal : NORMAL;
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

			sampler2D _DissolveTexture;
			float _DissolveAmount;

			float _ExtrudeAmount;


			//Vertex - Build the object
			//Get the positions of the vertices then pass to the screen
			//MVP - Model View Projection (data from camera)
			//Time = float4 - xyzw, x=20th speed, y=true speed, z=double
			v2f vertexFunction(appdata IN)
			{
				v2f OUT;

				//manipulating vertex before it is passed into the screen
				IN.vertex.xyz += IN.normal.xyz * _ExtrudeAmount * sin(_Time.y);

				OUT.position = mul(UNITY_MATRIX_MVP, IN.vertex);
				OUT.uv = IN.uv;

				return OUT;
			}


			//Fragment - Colours it in/draws pixels to screen
			fixed4 fragmentFunction(v2f IN) : SV_Target 
			{
				float4 textureColor = tex2D(_MainTexture, IN.uv);
				float4 dissolveColor = tex2D(_DissolveTexture, IN.uv);

				clip(dissolveColor.rgb - _DissolveAmount);

				return textureColor * _Color;
			}


			ENDCG
		}
	}
}