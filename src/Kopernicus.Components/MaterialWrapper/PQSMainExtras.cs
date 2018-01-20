// Material wrapper generated by shader translator tool
using System;
using UnityEngine;

namespace Kopernicus
{
    namespace MaterialWrapper
    {
        public class PQSMainExtras : Material
        {
            // Internal property ID tracking object
            protected class Properties
            {
                // Return the shader for this wrapper
                public const String shaderName = "Terrain/PQS/PQS Main - Extras";
                public static Shader shader
                {
                    get { return Shader.Find (shaderName); }
                }

                // Saturation, default = 1
                public const String saturationKey = "_saturation";
                public Int32 saturationID { get; private set; }

                // Contrast, default = 1
                public const String contrastKey = "_contrast";
                public Int32 contrastID { get; private set; }

                // Colour Unsaturation (A = Factor), default = (1,1,1,0)
                public const String tintColorKey = "_tintColor";
                public Int32 tintColorID { get; private set; }

                // Near Blend, default = 0.5
                public const String powerNearKey = "_powerNear";
                public Int32 powerNearID { get; private set; }

                // Far Blend, default = 0.5
                public const String powerFarKey = "_powerFar";
                public Int32 powerFarID { get; private set; }

                // NearFar Start, default = 2000
                public const String groundTexStartKey = "_groundTexStart";
                public Int32 groundTexStartID { get; private set; }

                // NearFar End, default = 10000
                public const String groundTexEndKey = "_groundTexEnd";
                public Int32 groundTexEndID { get; private set; }

                // Steep Blend, default = 1
                public const String steepPowerKey = "_steepPower";
                public Int32 steepPowerID { get; private set; }

                // Steep Fade Start, default = 20000
                public const String steepTexStartKey = "_steepTexStart";
                public Int32 steepTexStartID { get; private set; }

                // Steep Fade End, default = 30000
                public const String steepTexEndKey = "_steepTexEnd";
                public Int32 steepTexEndID { get; private set; }

                // Steep Texture, default = "white" {}
                public const String steepTexKey = "_steepTex";
                public Int32 steepTexID { get; private set; }

                // Steep Bump Map, default = "bump" {}
                public const String steepBumpMapKey = "_steepBumpMap";
                public Int32 steepBumpMapID { get; private set; }

                // Steep Near Tiling, default = 1
                public const String steepNearTilingKey = "_steepNearTiling";
                public Int32 steepNearTilingID { get; private set; }

                // Steep Far Tiling, default = 1
                public const String steepTilingKey = "_steepTiling";
                public Int32 steepTilingID { get; private set; }

                // Low Texture, default = "white" {}
                public const String lowTexKey = "_lowTex";
                public Int32 lowTexID { get; private set; }

                // Low Bump Map, default = "bump" {}
                public const String lowBumpMapKey = "_lowBumpMap";
                public Int32 lowBumpMapID { get; private set; }

                // Low Near Tiling, default = 1000
                public const String lowNearTilingKey = "_lowNearTiling";
                public Int32 lowNearTilingID { get; private set; }

                // Low Far Tiling, default = 10
                public const String lowMultiFactorKey = "_lowMultiFactor";
                public Int32 lowMultiFactorID { get; private set; }

                // Low Bump Near Tiling, default = 1
                public const String lowBumpNearTilingKey = "_lowBumpNearTiling";
                public Int32 lowBumpNearTilingID { get; private set; }

                // Low Bump Far Tiling, default = 1
                public const String lowBumpFarTilingKey = "_lowBumpFarTiling";
                public Int32 lowBumpFarTilingID { get; private set; }

                // Mid Texture, default = "white" {}
                public const String midTexKey = "_midTex";
                public Int32 midTexID { get; private set; }

                // Mid Bump Map, default = "bump" {}
                public const String midBumpMapKey = "_midBumpMap";
                public Int32 midBumpMapID { get; private set; }

                // Mid Near Tiling, default = 1000
                public const String midNearTilingKey = "_midNearTiling";
                public Int32 midNearTilingID { get; private set; }

                // Mid Far Tiling, default = 10
                public const String midMultiFactorKey = "_midMultiFactor";
                public Int32 midMultiFactorID { get; private set; }

                // Mid Bump Near Tiling, default = 1
                public const String midBumpNearTilingKey = "_midBumpNearTiling";
                public Int32 midBumpNearTilingID { get; private set; }

                // Mid Bump Far Tiling, default = 1
                public const String midBumpFarTilingKey = "_midBumpFarTiling";
                public Int32 midBumpFarTilingID { get; private set; }

                // High Texture, default = "white" {}
                public const String highTexKey = "_highTex";
                public Int32 highTexID { get; private set; }

                // High Bump Map, default = "bump" {}
                public const String highBumpMapKey = "_highBumpMap";
                public Int32 highBumpMapID { get; private set; }

                // High Near Tiling, default = 1000
                public const String highNearTilingKey = "_highNearTiling";
                public Int32 highNearTilingID { get; private set; }

                // High Far Tiling, default = 10
                public const String highMultiFactorKey = "_highMultiFactor";
                public Int32 highMultiFactorID { get; private set; }

                // High Bump Near Tiling, default = 1
                public const String highBumpNearTilingKey = "_highBumpNearTiling";
                public Int32 highBumpNearTilingID { get; private set; }

                // High Bump Far Tiling, default = 1
                public const String highBumpFarTilingKey = "_highBumpFarTiling";
                public Int32 highBumpFarTilingID { get; private set; }

                // Low Transition Start, default = 0
                public const String lowStartKey = "_lowStart";
                public Int32 lowStartID { get; private set; }

                // Low Transition End, default = 0.3
                public const String lowEndKey = "_lowEnd";
                public Int32 lowEndID { get; private set; }

                // High Transition Start, default = 0.8
                public const String highStartKey = "_highStart";
                public Int32 highStartID { get; private set; }

                // High Transition End, default = 1
                public const String highEndKey = "_highEnd";
                public Int32 highEndID { get; private set; }

                // AP Global Density, default = 1
                public const String globalDensityKey = "_globalDensity";
                public Int32 globalDensityID { get; private set; }

                // FogColorRamp, default = "white" {}
                public const String fogColorRampKey = "_fogColorRamp";
                public Int32 fogColorRampID { get; private set; }

                // PlanetOpacity, default = 1
                public const String planetOpacityKey = "_PlanetOpacity";
                public Int32 planetOpacityID { get; private set; }

                // Singleton instance
                private static Properties singleton = null;
                public static Properties Instance
                {
                    get
                    {
                        // Construct the singleton if it does not exist
                        if(singleton == null)
                            singleton = new Properties();
            
                        return singleton;
                    }
                }

                private Properties()
                {
                    saturationID = Shader.PropertyToID(saturationKey);
                    contrastID = Shader.PropertyToID(contrastKey);
                    tintColorID = Shader.PropertyToID(tintColorKey);
                    powerNearID = Shader.PropertyToID(powerNearKey);
                    powerFarID = Shader.PropertyToID(powerFarKey);
                    groundTexStartID = Shader.PropertyToID(groundTexStartKey);
                    groundTexEndID = Shader.PropertyToID(groundTexEndKey);
                    steepPowerID = Shader.PropertyToID(steepPowerKey);
                    steepTexStartID = Shader.PropertyToID(steepTexStartKey);
                    steepTexEndID = Shader.PropertyToID(steepTexEndKey);
                    steepTexID = Shader.PropertyToID(steepTexKey);
                    steepBumpMapID = Shader.PropertyToID(steepBumpMapKey);
                    steepNearTilingID = Shader.PropertyToID(steepNearTilingKey);
                    steepTilingID = Shader.PropertyToID(steepTilingKey);
                    lowTexID = Shader.PropertyToID(lowTexKey);
                    lowBumpMapID = Shader.PropertyToID(lowBumpMapKey);
                    lowNearTilingID = Shader.PropertyToID(lowNearTilingKey);
                    lowMultiFactorID = Shader.PropertyToID(lowMultiFactorKey);
                    lowBumpNearTilingID = Shader.PropertyToID(lowBumpNearTilingKey);
                    lowBumpFarTilingID = Shader.PropertyToID(lowBumpFarTilingKey);
                    midTexID = Shader.PropertyToID(midTexKey);
                    midBumpMapID = Shader.PropertyToID(midBumpMapKey);
                    midNearTilingID = Shader.PropertyToID(midNearTilingKey);
                    midMultiFactorID = Shader.PropertyToID(midMultiFactorKey);
                    midBumpNearTilingID = Shader.PropertyToID(midBumpNearTilingKey);
                    midBumpFarTilingID = Shader.PropertyToID(midBumpFarTilingKey);
                    highTexID = Shader.PropertyToID(highTexKey);
                    highBumpMapID = Shader.PropertyToID(highBumpMapKey);
                    highNearTilingID = Shader.PropertyToID(highNearTilingKey);
                    highMultiFactorID = Shader.PropertyToID(highMultiFactorKey);
                    highBumpNearTilingID = Shader.PropertyToID(highBumpNearTilingKey);
                    highBumpFarTilingID = Shader.PropertyToID(highBumpFarTilingKey);
                    lowStartID = Shader.PropertyToID(lowStartKey);
                    lowEndID = Shader.PropertyToID(lowEndKey);
                    highStartID = Shader.PropertyToID(highStartKey);
                    highEndID = Shader.PropertyToID(highEndKey);
                    globalDensityID = Shader.PropertyToID(globalDensityKey);
                    fogColorRampID = Shader.PropertyToID(fogColorRampKey);
                    planetOpacityID = Shader.PropertyToID(planetOpacityKey);
                }
            }

            // Is some random material this material
            public static Boolean UsesSameShader(Material m)
            {
                return m.shader.name == Properties.shaderName;
            }

            // Saturation, default = 1
            public Single saturation
            {
                get { return GetFloat (Properties.Instance.saturationID); }
                set { SetFloat (Properties.Instance.saturationID, value); }
            }

            // Contrast, default = 1
            public Single contrast
            {
                get { return GetFloat (Properties.Instance.contrastID); }
                set { SetFloat (Properties.Instance.contrastID, value); }
            }

            // Colour Unsaturation (A = Factor), default = (1,1,1,0)
            public Color tintColor
            {
                get { return GetColor (Properties.Instance.tintColorID); }
                set { SetColor (Properties.Instance.tintColorID, value); }
            }

            // Near Blend, default = 0.5
            public Single powerNear
            {
                get { return GetFloat (Properties.Instance.powerNearID); }
                set { SetFloat (Properties.Instance.powerNearID, value); }
            }

            // Far Blend, default = 0.5
            public Single powerFar
            {
                get { return GetFloat (Properties.Instance.powerFarID); }
                set { SetFloat (Properties.Instance.powerFarID, value); }
            }

            // NearFar Start, default = 2000
            public Single groundTexStart
            {
                get { return GetFloat (Properties.Instance.groundTexStartID); }
                set { SetFloat (Properties.Instance.groundTexStartID, value); }
            }

            // NearFar End, default = 10000
            public Single groundTexEnd
            {
                get { return GetFloat (Properties.Instance.groundTexEndID); }
                set { SetFloat (Properties.Instance.groundTexEndID, value); }
            }

            // Steep Blend, default = 1
            public Single steepPower
            {
                get { return GetFloat (Properties.Instance.steepPowerID); }
                set { SetFloat (Properties.Instance.steepPowerID, value); }
            }

            // Steep Fade Start, default = 20000
            public Single steepTexStart
            {
                get { return GetFloat (Properties.Instance.steepTexStartID); }
                set { SetFloat (Properties.Instance.steepTexStartID, value); }
            }

            // Steep Fade End, default = 30000
            public Single steepTexEnd
            {
                get { return GetFloat (Properties.Instance.steepTexEndID); }
                set { SetFloat (Properties.Instance.steepTexEndID, value); }
            }

            // Steep Texture, default = "white" {}
            public Texture2D steepTex
            {
                get { return GetTexture (Properties.Instance.steepTexID) as Texture2D; }
                set { SetTexture (Properties.Instance.steepTexID, value); }
            }

            public Vector2 steepTexScale
            {
                get { return GetTextureScale (Properties.steepTexKey); }
                set { SetTextureScale (Properties.steepTexKey, value); }
            }

            public Vector2 steepTexOffset
            {
                get { return GetTextureOffset (Properties.steepTexKey); }
                set { SetTextureOffset (Properties.steepTexKey, value); }
            }

            // Steep Bump Map, default = "bump" {}
            public Texture2D steepBumpMap
            {
                get { return GetTexture (Properties.Instance.steepBumpMapID) as Texture2D; }
                set { SetTexture (Properties.Instance.steepBumpMapID, value); }
            }

            public Vector2 steepBumpMapScale
            {
                get { return GetTextureScale (Properties.steepBumpMapKey); }
                set { SetTextureScale (Properties.steepBumpMapKey, value); }
            }

            public Vector2 steepBumpMapOffset
            {
                get { return GetTextureOffset (Properties.steepBumpMapKey); }
                set { SetTextureOffset (Properties.steepBumpMapKey, value); }
            }

            // Steep Near Tiling, default = 1
            public Single steepNearTiling
            {
                get { return GetFloat (Properties.Instance.steepNearTilingID); }
                set { SetFloat (Properties.Instance.steepNearTilingID, value); }
            }

            // Steep Far Tiling, default = 1
            public Single steepTiling
            {
                get { return GetFloat (Properties.Instance.steepTilingID); }
                set { SetFloat (Properties.Instance.steepTilingID, value); }
            }

            // Low Texture, default = "white" {}
            public Texture2D lowTex
            {
                get { return GetTexture (Properties.Instance.lowTexID) as Texture2D; }
                set { SetTexture (Properties.Instance.lowTexID, value); }
            }

            public Vector2 lowTexScale
            {
                get { return GetTextureScale (Properties.lowTexKey); }
                set { SetTextureScale (Properties.lowTexKey, value); }
            }

            public Vector2 lowTexOffset
            {
                get { return GetTextureOffset (Properties.lowTexKey); }
                set { SetTextureOffset (Properties.lowTexKey, value); }
            }

            // Low Bump Map, default = "bump" {}
            public Texture2D lowBumpMap
            {
                get { return GetTexture (Properties.Instance.lowBumpMapID) as Texture2D; }
                set { SetTexture (Properties.Instance.lowBumpMapID, value); }
            }

            public Vector2 lowBumpMapScale
            {
                get { return GetTextureScale (Properties.lowBumpMapKey); }
                set { SetTextureScale (Properties.lowBumpMapKey, value); }
            }

            public Vector2 lowBumpMapOffset
            {
                get { return GetTextureOffset (Properties.lowBumpMapKey); }
                set { SetTextureOffset (Properties.lowBumpMapKey, value); }
            }

            // Low Near Tiling, default = 1000
            public Single lowNearTiling
            {
                get { return GetFloat (Properties.Instance.lowNearTilingID); }
                set { SetFloat (Properties.Instance.lowNearTilingID, value); }
            }

            // Low Far Tiling, default = 10
            public Single lowMultiFactor
            {
                get { return GetFloat (Properties.Instance.lowMultiFactorID); }
                set { SetFloat (Properties.Instance.lowMultiFactorID, value); }
            }

            // Low Bump Near Tiling, default = 1
            public Single lowBumpNearTiling
            {
                get { return GetFloat (Properties.Instance.lowBumpNearTilingID); }
                set { SetFloat (Properties.Instance.lowBumpNearTilingID, value); }
            }

            // Low Bump Far Tiling, default = 1
            public Single lowBumpFarTiling
            {
                get { return GetFloat (Properties.Instance.lowBumpFarTilingID); }
                set { SetFloat (Properties.Instance.lowBumpFarTilingID, value); }
            }

            // Mid Texture, default = "white" {}
            public Texture2D midTex
            {
                get { return GetTexture (Properties.Instance.midTexID) as Texture2D; }
                set { SetTexture (Properties.Instance.midTexID, value); }
            }

            public Vector2 midTexScale
            {
                get { return GetTextureScale (Properties.midTexKey); }
                set { SetTextureScale (Properties.midTexKey, value); }
            }

            public Vector2 midTexOffset
            {
                get { return GetTextureOffset (Properties.midTexKey); }
                set { SetTextureOffset (Properties.midTexKey, value); }
            }

            // Mid Bump Map, default = "bump" {}
            public Texture2D midBumpMap
            {
                get { return GetTexture (Properties.Instance.midBumpMapID) as Texture2D; }
                set { SetTexture (Properties.Instance.midBumpMapID, value); }
            }

            public Vector2 midBumpMapScale
            {
                get { return GetTextureScale (Properties.midBumpMapKey); }
                set { SetTextureScale (Properties.midBumpMapKey, value); }
            }

            public Vector2 midBumpMapOffset
            {
                get { return GetTextureOffset (Properties.midBumpMapKey); }
                set { SetTextureOffset (Properties.midBumpMapKey, value); }
            }

            // Mid Near Tiling, default = 1000
            public Single midNearTiling
            {
                get { return GetFloat (Properties.Instance.midNearTilingID); }
                set { SetFloat (Properties.Instance.midNearTilingID, value); }
            }

            // Mid Far Tiling, default = 10
            public Single midMultiFactor
            {
                get { return GetFloat (Properties.Instance.midMultiFactorID); }
                set { SetFloat (Properties.Instance.midMultiFactorID, value); }
            }

            // Mid Bump Near Tiling, default = 1
            public Single midBumpNearTiling
            {
                get { return GetFloat (Properties.Instance.midBumpNearTilingID); }
                set { SetFloat (Properties.Instance.midBumpNearTilingID, value); }
            }

            // Mid Bump Far Tiling, default = 1
            public Single midBumpFarTiling
            {
                get { return GetFloat (Properties.Instance.midBumpFarTilingID); }
                set { SetFloat (Properties.Instance.midBumpFarTilingID, value); }
            }

            // High Texture, default = "white" {}
            public Texture2D highTex
            {
                get { return GetTexture (Properties.Instance.highTexID) as Texture2D; }
                set { SetTexture (Properties.Instance.highTexID, value); }
            }

            public Vector2 highTexScale
            {
                get { return GetTextureScale (Properties.highTexKey); }
                set { SetTextureScale (Properties.highTexKey, value); }
            }

            public Vector2 highTexOffset
            {
                get { return GetTextureOffset (Properties.highTexKey); }
                set { SetTextureOffset (Properties.highTexKey, value); }
            }

            // High Bump Map, default = "bump" {}
            public Texture2D highBumpMap
            {
                get { return GetTexture (Properties.Instance.highBumpMapID) as Texture2D; }
                set { SetTexture (Properties.Instance.highBumpMapID, value); }
            }

            public Vector2 highBumpMapScale
            {
                get { return GetTextureScale (Properties.highBumpMapKey); }
                set { SetTextureScale (Properties.highBumpMapKey, value); }
            }

            public Vector2 highBumpMapOffset
            {
                get { return GetTextureOffset (Properties.highBumpMapKey); }
                set { SetTextureOffset (Properties.highBumpMapKey, value); }
            }

            // High Near Tiling, default = 1000
            public Single highNearTiling
            {
                get { return GetFloat (Properties.Instance.highNearTilingID); }
                set { SetFloat (Properties.Instance.highNearTilingID, value); }
            }

            // High Far Tiling, default = 10
            public Single highMultiFactor
            {
                get { return GetFloat (Properties.Instance.highMultiFactorID); }
                set { SetFloat (Properties.Instance.highMultiFactorID, value); }
            }

            // High Bump Near Tiling, default = 1
            public Single highBumpNearTiling
            {
                get { return GetFloat (Properties.Instance.highBumpNearTilingID); }
                set { SetFloat (Properties.Instance.highBumpNearTilingID, value); }
            }

            // High Bump Far Tiling, default = 1
            public Single highBumpFarTiling
            {
                get { return GetFloat (Properties.Instance.highBumpFarTilingID); }
                set { SetFloat (Properties.Instance.highBumpFarTilingID, value); }
            }

            // Low Transition Start, default = 0
            public Single lowStart
            {
                get { return GetFloat (Properties.Instance.lowStartID); }
                set { SetFloat (Properties.Instance.lowStartID, value); }
            }

            // Low Transition End, default = 0.3
            public Single lowEnd
            {
                get { return GetFloat (Properties.Instance.lowEndID); }
                set { SetFloat (Properties.Instance.lowEndID, value); }
            }

            // High Transition Start, default = 0.8
            public Single highStart
            {
                get { return GetFloat (Properties.Instance.highStartID); }
                set { SetFloat (Properties.Instance.highStartID, value); }
            }

            // High Transition End, default = 1
            public Single highEnd
            {
                get { return GetFloat (Properties.Instance.highEndID); }
                set { SetFloat (Properties.Instance.highEndID, value); }
            }

            // AP Global Density, default = 1
            public Single globalDensity
            {
                get { return GetFloat (Properties.Instance.globalDensityID); }
                set { SetFloat (Properties.Instance.globalDensityID, value); }
            }

            // FogColorRamp, default = "white" {}
            public Texture2D fogColorRamp
            {
                get { return GetTexture (Properties.Instance.fogColorRampID) as Texture2D; }
                set { SetTexture (Properties.Instance.fogColorRampID, value); }
            }

            public Vector2 fogColorRampScale
            {
                get { return GetTextureScale (Properties.fogColorRampKey); }
                set { SetTextureScale (Properties.fogColorRampKey, value); }
            }

            public Vector2 fogColorRampOffset
            {
                get { return GetTextureOffset (Properties.fogColorRampKey); }
                set { SetTextureOffset (Properties.fogColorRampKey, value); }
            }

            // PlanetOpacity, default = 1
            public Single planetOpacity
            {
                get { return GetFloat (Properties.Instance.planetOpacityID); }
                set { SetFloat (Properties.Instance.planetOpacityID, value); }
            }

            public PQSMainExtras() : base(Properties.shader)
            {
            }

            [Obsolete("Creating materials from shader source String is no longer supported. Use Shader assets instead.")]
            public PQSMainExtras(String contents) : base(contents)
            {
                base.shader = Properties.shader;
            }

            public PQSMainExtras(Material material) : base(material)
            {
                // Throw exception if this material was not the proper material
                if (material.shader.name != Properties.shader.name)
                    throw new InvalidOperationException("Type Mismatch: Terrain/PQS/PQS Main - Optimised shader required");
            }

        }
    }
}
