Shader "Unlit/Shader 1"
{
     Properties
    {
        _MainTex ("Textura", 2D) = "white" {}
    }
    SubShader
    {
        Pass
        {
            CGPROGRAM
            #include "UnityCG.cginc"
            #pragma vertex vert
            #pragma fragment frag

            sampler2D _MainTex;
            float4 _MainTex_ST;

            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
                float3 normal : NORMAL; // Adiciona a normal do vértice
            };

            struct v2f
            {
                float4 pos : SV_POSITION;
                float2 uv : TEXCOORD0;
                float3 worldNormal : TEXCOORD1; // Passa a normal para o fragment shader
            };

            v2f vert (appdata v)
            {
                v2f o;
                o.pos = UnityObjectToClipPos(v.vertex);
                o.uv = TRANSFORM_TEX(v.uv, _MainTex);
                o.worldNormal = UnityObjectToWorldNormal(v.normal); // Calcula a normal no espaço do mundo
                return o;
            }

            fixed4 frag (v2f i) : SV_Target
            {
                fixed3 lightDir = normalize(_WorldSpaceLightPos0.xyz);
                fixed3 normal = normalize(i.worldNormal);
                fixed3 diffuse = max(0, dot(normal, lightDir));

                return tex2D(_MainTex, i.uv) * fixed4(diffuse, 1.0); // Multiplica por fixed4(diffuse, 1.0)
            }
            ENDCG
        }
    }
}
