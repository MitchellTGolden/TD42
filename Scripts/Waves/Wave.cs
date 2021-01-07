using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
    public class Wave
    {
        [SerializeField] private Enemy[] enemies = new Enemy[0];

        public Enemy[] Enemies => enemies;
    }
