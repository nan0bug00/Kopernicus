// Material wrapper generated by shader translator tool
using System;
using UnityEngine;

namespace Kopernicus
{
    namespace MaterialWrapper
    {
        public class PQSProjectionAerialQuadRelative : Material
        {
            // Internal property ID tracking object
            protected class Properties
            {
                // Return the shader for this wrapper
                private const String shaderName = "Terrain/PQS/Sphere Projection SURFACE QUAD (AP) ";
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

                // Near Tiling, default = 1000
                public const String texTilingKey = "_texTiling";
                public Int32 texTilingID { get; private set; }

                // Near Blend, default = 0.5
                public const String texPowerKey = "_texPower";
                public Int32 texPowerID { get; private set; }

                // Far Blend, default = 0.5
                public const String multiPowerKey = "_multiPower";
                public Int32 multiPowerID { get; private set; }

                // NearFar Start, default = 2000
                public const String groundTexStartKey = "_groundTexStart";
                public Int32 groundTexStartID { get; private set; }

                // NearFar Start, default = 10000
                public const String groundTexEndKey = "_groundTexEnd";
                public Int32 groundTexEndID { get; private set; }

                // Steep Tiling, default = 1
                public const String steepTilingKey = "_steepTiling";
                public Int32 steepTilingID { get; private set; }

                // Steep Blend, default = 1
                public const String steepPowerKey = "_steepPower";
                public Int32 steepPowerID { get; private set; }

                // Steep Fade Start, default = 20000
                public const String steepTexStartKey = "_steepTexStart";
                public Int32 steepTexStartID { get; private set; }

                // Steep Fade End, default = 30000
                public const String steepTexEndKey = "_steepTexEnd";
                public Int32 steepTexEndID { get; private set; }

                // Deep ground, default = "white" { }
                public const String deepTexKey = "_deepTex";
                public Int32 deepTexID { get; private set; }

                // Deep MT, default = "white" { }
                public const String deepMultiTexKey = "_deepMultiTex";
                public Int32 deepMultiTexID { get; private set; }

                // Deep MT Tiling, default = 1
                public const String deepMultiFactorKey = "_deepMultiFactor";
                public Int32 deepMultiFactorID { get; private set; }

                // Main Texture, default = "white" { }
                public const String mainTexKey = "_mainTex";
                public Int32 mainTexID { get; private set; }

                // Main MT, default = "white" { }
                public const String mainMultiTexKey = "_mainMultiTex";
                public Int32 mainMultiTexID { get; private set; }

                // Main MT Tiling, default = 1
                public const String mainMultiFactorKey = "_mainMultiFactor";
                public Int32 mainMultiFactorID { get; private set; }

                // High Ground, default = "white" { }
                public const String highTexKey = "_highTex";
                public Int32 highTexID { get; private set; }

                // High MT, default = "white" { }
                public const String highMultiTexKey = "_highMultiTex";
                public Int32 highMultiTexID { get; private set; }

                // High MT Tiling, default = 1
                public const String highMultiFactorKey = "_highMultiFactor";
                public Int32 highMultiFactorID { get; private set; }

                // Snow, default = "white" { }
                public const String snowTexKey = "_snowTex";
                public Int32 snowTexID { get; private set; }

                // Snow MT, default = "white" { }
                public const String snowMultiTexKey = "_snowMultiTex";
                public Int32 snowMultiTexID { get; private set; }

                // Snow MT Tiling, default = 1
                public const String snowMultiFactorKey = "_snowMultiFactor";
                public Int32 snowMultiFactorID { get; private set; }

                // Steep Texture, default = "white" { }
                public const String steepTexKey = "_steepTex";
                public Int32 steepTexID { get; private set; }

                // Deep Start, default = 0
                public const String deepStartKey = "_deepStart";
                public Int32 deepStartID { get; private set; }

                // Deep End, default = 0.3
                public const String deepEndKey = "_deepEnd";
                public Int32 deepEndID { get; private set; }

                // Main lower boundary start, default = 0
                public const String mainLoStartKey = "_mainLoStart";
                public Int32 mainLoStartID { get; private set; }

                // Main lower boundary end, default = 0.5
                public const String mainLoEndKey = "_mainLoEnd";
                public Int32 mainLoEndID { get; private set; }

                // Main upper boundary start, default = 0.3
                public const String mainHiStartKey = "_mainHiStart";
                public Int32 mainHiStartID { get; private set; }

                // Main upper boundary end, default = 0.5
                public const String mainHiEndKey = "_mainHiEnd";
                public Int32 mainHiEndID { get; private set; }

                // High lower boundary start, default = 0.6
                public const String hiLoStartKey = "_hiLoStart";
                public Int32 hiLoStartID { get; private set; }

                // High lower boundary end, default = 0.6
                public const String hiLoEndKey = "_hiLoEnd";
                public Int32 hiLoEndID { get; private set; }

                // High upper boundary start, default = 0.6
                public const String hiHiStartKey = "_hiHiStart";
                public Int32 hiHiStartID { get; private set; }

                // High upper boundary end, default = 0.9
                public const String hiHiEndKey = "_hiHiEnd";
                public Int32 hiHiEndID { get; private set; }

                // Snow Start, default = 0.9
                public const String snowStartKey = "_snowStart";
                public Int32 snowStartID { get; private set; }

                // Snow End, default = 1
                public const String snowEndKey = "_snowEnd";
                public Int32 snowEndID { get; private set; }

                // AP Fog Color, default = (0,0,1,1)
                public const String fogColorKey = "_fogColor";
                public Int32 fogColorID { get; private set; }

                // AP Height Fall Off, default = 1
                public const String heightFallOffKey = "_heightFallOff";
                public Int32 heightFallOffID { get; private set; }

                // AP Global Density, default = 1
                public const String globalDensityKey = "_globalDensity";
                public Int32 globalDensityID { get; private set; }

                // AP Atmosphere Depth, default = 1
                public const String atmosphereDepthKey = "_atmosphereDepth";
                public Int32 atmosphereDepthID { get; private set; }

                // FogColorRamp, default = "white" { }
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
                    texTilingID = Shader.PropertyToID(texTilingKey);
                    texPowerID = Shader.PropertyToID(texPowerKey);
                    multiPowerID = Shader.PropertyToID(multiPowerKey);
                    groundTexStartID = Shader.PropertyToID(groundTexStartKey);
                    groundTexEndID = Shader.PropertyToID(groundTexEndKey);
                    steepTilingID = Shader.PropertyToID(steepTilingKey);
                    steepPowerID = Shader.PropertyToID(steepPowerKey);
                    steepTexStartID = Shader.PropertyToID(steepTexStartKey);
                    steepTexEndID = Shader.PropertyToID(steepTexEndKey);
                    deepTexID = Shader.PropertyToID(deepTexKey);
                    deepMultiTexID = Shader.PropertyToID(deepMultiTexKey);
                    deepMultiFactorID = Shader.PropertyToID(deepMultiFactorKey);
                    mainTexID = Shader.PropertyToID(mainTexKey);
                    mainMultiTexID = Shader.PropertyToID(mainMultiTexKey);
                    mainMultiFactorID = Shader.PropertyToID(mainMultiFactorKey);
                    highTexID = Shader.PropertyToID(highTexKey);
                    highMultiTexID = Shader.PropertyToID(highMultiTexKey);
                    highMultiFactorID = Shader.PropertyToID(highMultiFactorKey);
                    snowTexID = Shader.PropertyToID(snowTexKey);
                    snowMultiTexID = Shader.PropertyToID(snowMultiTexKey);
                    snowMultiFactorID = Shader.PropertyToID(snowMultiFactorKey);
                    steepTexID = Shader.PropertyToID(steepTexKey);
                    deepStartID = Shader.PropertyToID(deepStartKey);
                    deepEndID = Shader.PropertyToID(deepEndKey);
                    mainLoStartID = Shader.PropertyToID(mainLoStartKey);
                    mainLoEndID = Shader.PropertyToID(mainLoEndKey);
                    mainHiStartID = Shader.PropertyToID(mainHiStartKey);
                    mainHiEndID = Shader.PropertyToID(mainHiEndKey);
                    hiLoStartID = Shader.PropertyToID(hiLoStartKey);
                    hiLoEndID = Shader.PropertyToID(hiLoEndKey);
                    hiHiStartID = Shader.PropertyToID(hiHiStartKey);
                    hiHiEndID = Shader.PropertyToID(hiHiEndKey);
                    snowStartID = Shader.PropertyToID(snowStartKey);
                    snowEndID = Shader.PropertyToID(snowEndKey);
                    fogColorID = Shader.PropertyToID(fogColorKey);
                    heightFallOffID = Shader.PropertyToID(heightFallOffKey);
                    globalDensityID = Shader.PropertyToID(globalDensityKey);
                    atmosphereDepthID = Shader.PropertyToID(atmosphereDepthKey);
                    fogColorRampID = Shader.PropertyToID(fogColorRampKey);
                    planetOpacityID = Shader.PropertyToID(planetOpacityKey);
                }
            }

            // Is some random material this material 
            public static Boolean UsesSameShader(Material m)
            {
                return m.shader.name == Properties.shader.name;
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

            // Near Tiling, default = 1000
            public Single texTiling
            {
                get { return GetFloat (Properties.Instance.texTilingID); }
                set { SetFloat (Properties.Instance.texTilingID, value); }
            }

            // Near Blend, default = 0.5
            public Single texPower
            {
                get { return GetFloat (Properties.Instance.texPowerID); }
                set { SetFloat (Properties.Instance.texPowerID, value); }
            }

            // Far Blend, default = 0.5
            public Single multiPower
            {
                get { return GetFloat (Properties.Instance.multiPowerID); }
                set { SetFloat (Properties.Instance.multiPowerID, value); }
            }

            // NearFar Start, default = 2000
            public Single groundTexStart
            {
                get { return GetFloat (Properties.Instance.groundTexStartID); }
                set { SetFloat (Properties.Instance.groundTexStartID, value); }
            }

            // NearFar Start, default = 10000
            public Single groundTexEnd
            {
                get { return GetFloat (Properties.Instance.groundTexEndID); }
                set { SetFloat (Properties.Instance.groundTexEndID, value); }
            }

            // Steep Tiling, default = 1
            public Single steepTiling
            {
                get { return GetFloat (Properties.Instance.steepTilingID); }
                set { SetFloat (Properties.Instance.steepTilingID, value); }
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

            // Deep ground, default = "white" { }
            public Texture2D deepTex
            {
                get { return GetTexture (Properties.Instance.deepTexID) as Texture2D; }
                set { SetTexture (Properties.Instance.deepTexID, value); }
            }

            public Vector2 deepTexScale
            {
                get { return GetTextureScale (Properties.deepTexKey); }
                set { SetTextureScale (Properties.deepTexKey, value); }
            }

            public Vector2 deepTexOffset
            {
                get { return GetTextureOffset (Properties.deepTexKey); }
                set { SetTextureOffset (Properties.deepTexKey, value); }
            }

            // Deep MT, default = "white" { }
            public Texture2D deepMultiTex
            {
                get { return GetTexture (Properties.Instance.deepMultiTexID) as Texture2D; }
                set { SetTexture (Properties.Instance.deepMultiTexID, value); }
            }

            public Vector2 deepMultiTexScale
            {
                get { return GetTextureScale (Properties.deepMultiTexKey); }
                set { SetTextureScale (Properties.deepMultiTexKey, value); }
            }

            public Vector2 deepMultiTexOffset
            {
                get { return GetTextureOffset (Properties.deepMultiTexKey); }
                set { SetTextureOffset (Properties.deepMultiTexKey, value); }
            }

            // Deep MT Tiling, default = 1
            public Single deepMultiFactor
            {
                get { return GetFloat (Properties.Instance.deepMultiFactorID); }
                set { SetFloat (Properties.Instance.deepMultiFactorID, value); }
            }

            // Main Texture, default = "white" { }
            public Texture2D mainTex
            {
                get { return GetTexture (Properties.Instance.mainTexID) as Texture2D; }
                set { SetTexture (Properties.Instance.mainTexID, value); }
            }

            public Vector2 mainTexScale
            {
                get { return GetTextureScale (Properties.mainTexKey); }
                set { SetTextureScale (Properties.mainTexKey, value); }
            }

            public Vector2 mainTexOffset
            {
                get { return GetTextureOffset (Properties.mainTexKey); }
                set { SetTextureOffset (Properties.mainTexKey, value); }
            }

            // Main MT, default = "white" { }
            public Texture2D mainMultiTex
            {
                get { return GetTexture (Properties.Instance.mainMultiTexID) as Texture2D; }
                set { SetTexture (Properties.Instance.mainMultiTexID, value); }
            }

            public Vector2 mainMultiTexScale
            {
                get { return GetTextureScale (Properties.mainMultiTexKey); }
                set { SetTextureScale (Properties.mainMultiTexKey, value); }
            }

            public Vector2 mainMultiTexOffset
            {
                get { return GetTextureOffset (Properties.mainMultiTexKey); }
                set { SetTextureOffset (Properties.mainMultiTexKey, value); }
            }

            // Main MT Tiling, default = 1
            public Single mainMultiFactor
            {
                get { return GetFloat (Properties.Instance.mainMultiFactorID); }
                set { SetFloat (Properties.Instance.mainMultiFactorID, value); }
            }

            // High Ground, default = "white" { }
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

            // High MT, default = "white" { }
            public Texture2D highMultiTex
            {
                get { return GetTexture (Properties.Instance.highMultiTexID) as Texture2D; }
                set { SetTexture (Properties.Instance.highMultiTexID, value); }
            }

            public Vector2 highMultiTexScale
            {
                get { return GetTextureScale (Properties.highMultiTexKey); }
                set { SetTextureScale (Properties.highMultiTexKey, value); }
            }

            public Vector2 highMultiTexOffset
            {
                get { return GetTextureOffset (Properties.highMultiTexKey); }
                set { SetTextureOffset (Properties.highMultiTexKey, value); }
            }

            // High MT Tiling, default = 1
            public Single highMultiFactor
            {
                get { return GetFloat (Properties.Instance.highMultiFactorID); }
                set { SetFloat (Properties.Instance.highMultiFactorID, value); }
            }

            // Snow, default = "white" { }
            public Texture2D snowTex
            {
                get { return GetTexture (Properties.Instance.snowTexID) as Texture2D; }
                set { SetTexture (Properties.Instance.snowTexID, value); }
            }

            public Vector2 snowTexScale
            {
                get { return GetTextureScale (Properties.snowTexKey); }
                set { SetTextureScale (Properties.snowTexKey, value); }
            }

            public Vector2 snowTexOffset
            {
                get { return GetTextureOffset (Properties.snowTexKey); }
                set { SetTextureOffset (Properties.snowTexKey, value); }
            }

            // Snow MT, default = "white" { }
            public Texture2D snowMultiTex
            {
                get { return GetTexture (Properties.Instance.snowMultiTexID) as Texture2D; }
                set { SetTexture (Properties.Instance.snowMultiTexID, value); }
            }

            public Vector2 snowMultiTexScale
            {
                get { return GetTextureScale (Properties.snowMultiTexKey); }
                set { SetTextureScale (Properties.snowMultiTexKey, value); }
            }

            public Vector2 snowMultiTexOffset
            {
                get { return GetTextureOffset (Properties.snowMultiTexKey); }
                set { SetTextureOffset (Properties.snowMultiTexKey, value); }
            }

            // Snow MT Tiling, default = 1
            public Single snowMultiFactor
            {
                get { return GetFloat (Properties.Instance.snowMultiFactorID); }
                set { SetFloat (Properties.Instance.snowMultiFactorID, value); }
            }

            // Steep Texture, default = "white" { }
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

            // Deep Start, default = 0
            public Single deepStart
            {
                get { return GetFloat (Properties.Instance.deepStartID); }
                set { SetFloat (Properties.Instance.deepStartID, value); }
            }

            // Deep End, default = 0.3
            public Single deepEnd
            {
                get { return GetFloat (Properties.Instance.deepEndID); }
                set { SetFloat (Properties.Instance.deepEndID, value); }
            }

            // Main lower boundary start, default = 0
            public Single mainLoStart
            {
                get { return GetFloat (Properties.Instance.mainLoStartID); }
                set { SetFloat (Properties.Instance.mainLoStartID, value); }
            }

            // Main lower boundary end, default = 0.5
            public Single mainLoEnd
            {
                get { return GetFloat (Properties.Instance.mainLoEndID); }
                set { SetFloat (Properties.Instance.mainLoEndID, value); }
            }

            // Main upper boundary start, default = 0.3
            public Single mainHiStart
            {
                get { return GetFloat (Properties.Instance.mainHiStartID); }
                set { SetFloat (Properties.Instance.mainHiStartID, value); }
            }

            // Main upper boundary end, default = 0.5
            public Single mainHiEnd
            {
                get { return GetFloat (Properties.Instance.mainHiEndID); }
                set { SetFloat (Properties.Instance.mainHiEndID, value); }
            }

            // High lower boundary start, default = 0.6
            public Single hiLoStart
            {
                get { return GetFloat (Properties.Instance.hiLoStartID); }
                set { SetFloat (Properties.Instance.hiLoStartID, value); }
            }

            // High lower boundary end, default = 0.6
            public Single hiLoEnd
            {
                get { return GetFloat (Properties.Instance.hiLoEndID); }
                set { SetFloat (Properties.Instance.hiLoEndID, value); }
            }

            // High upper boundary start, default = 0.6
            public Single hiHiStart
            {
                get { return GetFloat (Properties.Instance.hiHiStartID); }
                set { SetFloat (Properties.Instance.hiHiStartID, value); }
            }

            // High upper boundary end, default = 0.9
            public Single hiHiEnd
            {
                get { return GetFloat (Properties.Instance.hiHiEndID); }
                set { SetFloat (Properties.Instance.hiHiEndID, value); }
            }

            // Snow Start, default = 0.9
            public Single snowStart
            {
                get { return GetFloat (Properties.Instance.snowStartID); }
                set { SetFloat (Properties.Instance.snowStartID, value); }
            }

            // Snow End, default = 1
            public Single snowEnd
            {
                get { return GetFloat (Properties.Instance.snowEndID); }
                set { SetFloat (Properties.Instance.snowEndID, value); }
            }

            // AP Fog Color, default = (0,0,1,1)
            public Color fogColor
            {
                get { return GetColor (Properties.Instance.fogColorID); }
                set { SetColor (Properties.Instance.fogColorID, value); }
            }

            // AP Height Fall Off, default = 1
            public Single heightFallOff
            {
                get { return GetFloat (Properties.Instance.heightFallOffID); }
                set { SetFloat (Properties.Instance.heightFallOffID, value); }
            }

            // AP Global Density, default = 1
            public Single globalDensity
            {
                get { return GetFloat (Properties.Instance.globalDensityID); }
                set { SetFloat (Properties.Instance.globalDensityID, value); }
            }

            // AP Atmosphere Depth, default = 1
            public Single atmosphereDepth
            {
                get { return GetFloat (Properties.Instance.atmosphereDepthID); }
                set { SetFloat (Properties.Instance.atmosphereDepthID, value); }
            }

            // FogColorRamp, default = "white" { }
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

            public PQSProjectionAerialQuadRelative() : base(Properties.shader)
            {
            }

            [Obsolete("Creating materials from shader source String is no longer supported. Use Shader assets instead.")]
            public PQSProjectionAerialQuadRelative(String contents) : base(contents)
            {
                base.shader = Properties.shader;
            }

            public PQSProjectionAerialQuadRelative(Material material) : base(material)
            {
                // Throw exception if this material was not the proper material
                if (material.shader.name != Properties.shader.name)
                    throw new InvalidOperationException("Type Mismatch: Terrain/PQS/Sphere Projection SURFACE QUAD (AP)  shader required");
            }

        }
    }
}