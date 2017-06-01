// Upgrade NOTE: replaced '_Object2World' with 'unity_ObjectToWorld'

Shader "Custom/Test/ShaderTest_XposCol2"
{
	Properties 
	{
		_TopColor("Top Color", Color) = (1,1,1,1)
		_BottomColor("Bottom Color", Color) = (1,1,1,1)
		_GradientBlendAmount("Gradient Blend Amount", float) = 1
	}

	SubShader
	{
		Pass
		{
			CGPROGRAM

			#pragma vertex vertexFunction
			#pragma fragment fragmentFunction

			#include "UnityCG.cginc"

			struct appdata
			{
				float4 vertex : POSITION;
			};

			struct v2f
			{
				float4 position : SV_POSITION;
				float3 worldPosition : TEXCOORD0;
			};

			float4 _TopColor;
			float4 _BottomColor;
			float _GradientBlendAmount;

			v2f vertexFunction (appdata i)
			{
				v2f o;

				o.position = mul(UNITY_MATRIX_MVP, i.vertex);
				o.worldPosition = mul(unity_ObjectToWorld, i.vertex).xyz;

				return o;
			}

			fixed4 fragmentFunction (v2f i) : SV_TARGET
			{
				float4 gradientColor = lerp(_BottomColor, _TopColor, i.worldPosition.x * _GradientBlendAmount);

				return gradientColor;
			}

			ENDCG
		}
	}
}