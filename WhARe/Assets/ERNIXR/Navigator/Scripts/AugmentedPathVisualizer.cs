using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleARCore.Examples.AugmentedImage;

namespace ERNIXR
{

    public class AugmentedPathVisualizer : AugmentedImageVisualizer
    {
        [Tooltip("Instead of anchor this will set a custom height.")]
        public bool overrideSpawnHeight;
        [Tooltip("Custom height based on user ground.")]
        public float customSpawnHeight;

    // Use this for initialization
        void Start () {

        }

        // Update is called once per frame
        new void Update () {

        }
    }
}