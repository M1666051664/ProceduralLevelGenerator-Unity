﻿using Assets.ProceduralLevelGenerator.Scripts.Legacy.PrecomputedLevels;
using Assets.ProceduralLevelGenerator.Scripts.Pipeline;
using UnityEngine;

namespace Assets.ProceduralLevelGenerator.Scripts.Legacy.DungeonGenerators.GraphBasedGenerator
{
    /// <summary>
    ///     Represents a pipeline item that is used to generate dungeons.
    /// </summary>
    [CreateAssetMenu(menuName = "Dungeon generator/Generators/Graph based generator", fileName = "GraphBasedGenerator")]
    public class GraphBasedGeneratorConfig : PipelineConfig
    {
        /// <summary>
        ///     Whether to copy tiles from individual room templates to the
        ///     common tilemaps that will hold the generated dungeon.
        /// </summary>
        public bool ApplyTemplate = true;

        /// <summary>
        ///     Whether to center grid after a dungeon is generated.
        /// </summary>
        public bool CenterGrid = true;

        // TODO: documentation
        public AbstractPrecomputedLevelsHandler PrecomputedLevelsHandler;

        /// <summary>
        ///     Whether to show debug info.
        /// </summary>
        public bool ShowDebugInfo = true;

        /// <summary>
        ///     Number of milliseconds before the current attempt to generate
        ///     a layout is aborted.
        /// </summary>
        public int Timeout = 10000;

        /// <summary>
        ///     Whether map description should be exported on the next run of the generator.
        /// </summary>
        public bool ExportMapDescription;

        public bool UsePrecomputedLevelsOnly = false;
    }
}