Shader "CuboidLine/Normal"
{

	Properties
	{
        _Thickness ("Thickness", Float) = 0.1
	}

	SubShader
	{
		Tags { "RenderType"="Opaque" }
		LOD 100
		Cull Off

		Pass
		{
			CGPROGRAM
			#include "CuboidLine.cginc"

			#pragma vertex vert
			#pragma geometry geom
			#pragma fragment frag

			fixed4 frag (g2f i) : SV_Target
			{
				return fixed4((i.normal + 1.0) * 0.5, 1);
			}

			ENDCG
		}
	}
}
