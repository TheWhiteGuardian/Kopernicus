// Material wrapper generated by shader translator tool
using System;
using System.Reflection;
using UnityEngine;

using Kopernicus.MaterialWrapper;

namespace Kopernicus
{
    namespace Configuration
    {
        public class PQSOceanSurfaceQuadFallbackLoader : PQSOceanSurfaceQuadFallback
        {
            // Main Color, default = (1,1,1,1)
            [ParserTarget("color")]
            public ColorParser colorSetter
            {
                get { return color; }
                set { color = value; }
            }

            // Color From Space, default = (1,1,1,1)
            [ParserTarget("colorFromSpace")]
            public ColorParser colorFromSpaceSetter
            {
                get { return colorFromSpace; }
                set { colorFromSpace = value; }
            }

            // Specular Color, default = (1,1,1,1)
            [ParserTarget("specColor")]
            public ColorParser specColorSetter
            {
                get { return specColor; }
                set { specColor = value; }
            }

            // Shininess, default = 0.078125
            [ParserTarget("shininess")]
            public NumericParser<float> shininessSetter
            {
                get { return shininess; }
                set { shininess = value; }
            }

            // Gloss, default = 0.078125
            [ParserTarget("gloss")]
            public NumericParser<float> glossSetter
            {
                get { return gloss; }
                set { gloss = value; }
            }

            // Tex Tiling, default = 1
            [ParserTarget("tiling")]
            public NumericParser<float> tilingSetter
            {
                get { return tiling; }
                set { tiling = value; }
            }

            // Tex0, default = "white" { }
            [ParserTarget("waterTex")]
            public Texture2DParser waterTexSetter
            {
                get { return waterTex; }
                set { waterTex = value; }
            }

            [ParserTarget("waterTexScale")]
            private Vector2Parser waterTexScaleSetter
            {
                get { return waterTexScale; }
                set { waterTexScale = value; }
            }

            [ParserTarget("waterTexOffset")]
            private Vector2Parser waterTexOffsetSetter
            {
                get { return waterTexOffset; }
                set { waterTexOffset = value; }
            }

            // Tex1, default = "white" { }
            [ParserTarget("waterTex1")]
            public Texture2DParser waterTex1Setter
            {
                get { return waterTex1; }
                set { waterTex1 = value; }
            }

            [ParserTarget("waterTex1Scale")]
            private Vector2Parser waterTex1ScaleSetter
            {
                get { return waterTex1Scale; }
                set { waterTex1Scale = value; }
            }

            [ParserTarget("waterTex1Offset")]
            private Vector2Parser waterTex1OffsetSetter
            {
                get { return waterTex1Offset; }
                set { waterTex1Offset = value; }
            }

            // FadeStart, default = 1
            [ParserTarget("fadeStart")]
            public NumericParser<float> fadeStartSetter
            {
                get { return fadeStart; }
                set { fadeStart = value; }
            }

            // FadeEnd, default = 1
            [ParserTarget("fadeEnd")]
            public NumericParser<float> fadeEndSetter
            {
                get { return fadeEnd; }
                set { fadeEnd = value; }
            }

            // PlanetOpacity, default = 1
            [ParserTarget("planetOpacity")]
            public NumericParser<float> planetOpacitySetter
            {
                get { return planetOpacity; }
                set { planetOpacity = value; }
            }

            // Constructors
            public PQSOceanSurfaceQuadFallbackLoader () : base() { }
            public PQSOceanSurfaceQuadFallbackLoader (string contents) : base (contents) { }
            public PQSOceanSurfaceQuadFallbackLoader (Material material) : base(material) { }
        }
    }
}
