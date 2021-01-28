// Material wrapper generated by shader translator tool
#if (KSP_VERSION_1_9_1 || KSP_VERSION_1_10_1 || KSP_VERSION_1_11_1)
using System;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;

namespace Kopernicus.Components.MaterialWrapper
{
    [SuppressMessage("ReSharper", "MemberCanBePrivate.Global")]
    [SuppressMessage("ReSharper", "AutoPropertyCanBeMadeGetOnly.Local")]
    [SuppressMessage("ReSharper", "MemberCanBeProtected.Global")]
    public class ScaledPlanetRimAerialStandard : Material
    {
        // Internal property ID tracking object
        protected class Properties
        {
            // Return the shader for this wrapper
            private const String SHADER_NAME = "Terrain/Scaled Planet (RimAerial) Standard";

            public static Shader Shader
            {
                get { return Shader.Find(SHADER_NAME); }
            }

            // Main Color, default = (1,1,1,1)
            public const String COLOR_KEY = "_Color";
            public Int32 ColorId { get; private set; }

            // Specular Color, default = (0.5,0.5,0.5,1)
            public const String SPEC_COLOR_KEY = "_SpecColor";
            public Int32 SpecColorId { get; private set; }

            // Shininess, default = 0.078125
            public const String SHININESS_KEY = "_Shininess";
            public Int32 ShininessId { get; private set; }

            // Base (RGB) Gloss (A), default = "white" { }
            public const String MAIN_TEX_KEY = "_MainTex";
            public Int32 MainTexId { get; private set; }

            // Normal map, default = "bump" { }
            public const String BUMP_MAP_KEY = "_BumpMap";
            public Int32 BumpMapId { get; private set; }

            // Opacity, default = 1
            public const String OPACITY_KEY = "_Opacity";
            public Int32 OpacityId { get; private set; }

            // Rim Power, default = 3
            public const String RIM_POWER_KEY = "_rimPower";
            public Int32 RimPowerId { get; private set; }

            // Rim Blend, default = 1
            public const String RIM_BLEND_KEY = "_rimBlend";
            public Int32 RimBlendId { get; private set; }

            // RimColorRamp, default = "white" { }
            public const String RIM_COLOR_RAMP_KEY = "_rimColorRamp";
            public Int32 RimColorRampId { get; private set; }

            // LightDirection, default = (1,0,0,0)
            public const String LOCAL_LIGHT_DIRECTION_KEY = "_localLightDirection";
            public Int32 LocalLightDirectionId { get; private set; }

            // Resource Map (RGB), default = "black" { }
            public const String RESOURCE_MAP_KEY = "_ResourceMap";
            public Int32 ResourceMapId { get; private set; }

            // Singleton instance
            private static Properties _singleton;

            public static Properties Instance
            {
                get
                {
                    // Construct the singleton if it does not exist
                    return _singleton ?? (_singleton = new Properties());
                }
            }

            private Properties()
            {
                ColorId = Shader.PropertyToID(COLOR_KEY);
                SpecColorId = Shader.PropertyToID(SPEC_COLOR_KEY);
                ShininessId = Shader.PropertyToID(SHININESS_KEY);
                MainTexId = Shader.PropertyToID(MAIN_TEX_KEY);
                BumpMapId = Shader.PropertyToID(BUMP_MAP_KEY);
                OpacityId = Shader.PropertyToID(OPACITY_KEY);
                RimPowerId = Shader.PropertyToID(RIM_POWER_KEY);
                RimBlendId = Shader.PropertyToID(RIM_BLEND_KEY);
                RimColorRampId = Shader.PropertyToID(RIM_COLOR_RAMP_KEY);
                LocalLightDirectionId = Shader.PropertyToID(LOCAL_LIGHT_DIRECTION_KEY);
                ResourceMapId = Shader.PropertyToID(RESOURCE_MAP_KEY);
            }
        }

        // Is some random material this material 
        public static Boolean UsesSameShader(Material m)
        {
            if (m == null)
            {
                return false;
            }

            return m.shader.name == Properties.Shader.name;
        }

        // Main Color, default = (1,1,1,1)
        public Color Color
        {
            get { return GetColor(Properties.Instance.ColorId); }
            set { SetColor(Properties.Instance.ColorId, value); }
        }

        // Specular Color, default = (0.5,0.5,0.5,1)
        public Color SpecColor
        {
            get { return GetColor(Properties.Instance.SpecColorId); }
            set { SetColor(Properties.Instance.SpecColorId, value); }
        }

        // Shininess, default = 0.078125
        public Single Shininess
        {
            get { return GetFloat(Properties.Instance.ShininessId); }
            set { SetFloat(Properties.Instance.ShininessId, Mathf.Clamp(value, 0.03f, 1f)); }
        }

        // Base (RGB) Gloss (A), default = "white" { }
        public Texture2D MainTex
        {
            get { return GetTexture(Properties.Instance.MainTexId) as Texture2D; }
            set { SetTexture(Properties.Instance.MainTexId, value); }
        }

        public Vector2 MainTexScale
        {
            get { return GetTextureScale(Properties.Instance.MainTexId); }
            set { SetTextureScale(Properties.Instance.MainTexId, value); }
        }

        public Vector2 MainTexOffset
        {
            get { return GetTextureOffset(Properties.Instance.MainTexId); }
            set { SetTextureOffset(Properties.Instance.MainTexId, value); }
        }

        // Normal map, default = "bump" { }
        public Texture2D BumpMap
        {
            get { return GetTexture(Properties.Instance.BumpMapId) as Texture2D; }
            set { SetTexture(Properties.Instance.BumpMapId, value); }
        }

        public Vector2 BumpMapScale
        {
            get { return GetTextureScale(Properties.Instance.BumpMapId); }
            set { SetTextureScale(Properties.Instance.BumpMapId, value); }
        }

        public Vector2 BumpMapOffset
        {
            get { return GetTextureOffset(Properties.Instance.BumpMapId); }
            set { SetTextureOffset(Properties.Instance.BumpMapId, value); }
        }

        // Opacity, default = 1
        public Single Opacity
        {
            get { return GetFloat(Properties.Instance.OpacityId); }
            set { SetFloat(Properties.Instance.OpacityId, Mathf.Clamp(value, 0f, 1f)); }
        }

        // Rim Power, default = 3
        public Single RimPower
        {
            get { return GetFloat(Properties.Instance.RimPowerId); }
            set { SetFloat(Properties.Instance.RimPowerId, value); }
        }

        // Rim Blend, default = 1
        public Single RimBlend
        {
            get { return GetFloat(Properties.Instance.RimBlendId); }
            set { SetFloat(Properties.Instance.RimBlendId, value); }
        }

        // RimColorRamp, default = "white" { }
        public Texture2D RimColorRamp
        {
            get { return GetTexture(Properties.Instance.RimColorRampId) as Texture2D; }
            set
            {
                if (value)
                {
                    value.wrapMode = TextureWrapMode.Clamp;
                    value.mipMapBias = 0.0f;
                }

                SetTexture(Properties.Instance.RimColorRampId, value);
            }
        }

        public Vector2 RimColorRampScale
        {
            get { return GetTextureScale(Properties.Instance.RimColorRampId); }
            set { SetTextureScale(Properties.Instance.RimColorRampId, value); }
        }

        public Vector2 RimColorRampOffset
        {
            get { return GetTextureOffset(Properties.Instance.RimColorRampId); }
            set { SetTextureOffset(Properties.Instance.RimColorRampId, value); }
        }

        // LightDirection, default = (1,0,0,0)
        public Vector4 LocalLightDirection
        {
            get { return GetVector(Properties.Instance.LocalLightDirectionId); }
            set { SetVector(Properties.Instance.LocalLightDirectionId, value); }
        }

        // Resource Map (RGB), default = "black" { }
        public Texture2D ResourceMap
        {
            get { return GetTexture(Properties.Instance.ResourceMapId) as Texture2D; }
            set { SetTexture(Properties.Instance.ResourceMapId, value); }
        }

        public Vector2 ResourceMapScale
        {
            get { return GetTextureScale(Properties.Instance.ResourceMapId); }
            set { SetTextureScale(Properties.Instance.ResourceMapId, value); }
        }

        public Vector2 ResourceMapOffset
        {
            get { return GetTextureOffset(Properties.Instance.ResourceMapId); }
            set { SetTextureOffset(Properties.Instance.ResourceMapId, value); }
        }

        public ScaledPlanetRimAerialStandard() : base(Properties.Shader)
        {
        }

        [Obsolete("Creating materials from shader source String is no longer supported. Use Shader assets instead.")]
        public ScaledPlanetRimAerialStandard(String contents) : base(contents)
        {
            shader = Properties.Shader;
        }

        public ScaledPlanetRimAerialStandard(Material material) : base(material)
        {
            // Throw exception if this material was not the proper material
            if (material.shader.name != Properties.Shader.name)
            {
                throw new InvalidOperationException("Type Mismatch: Terrain/Scaled Planet (RimAerial) Standard shader required");
            }
        }

    }
}
#endif