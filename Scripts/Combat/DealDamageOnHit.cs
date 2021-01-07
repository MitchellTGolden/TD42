﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DealDamageOnHit : MonoBehaviour
    {
        [SerializeField] private int damage = 10;

        private void OnTriggerEnter(Collider other)
        {
            if (!other.TryGetComponent<Enemy>(out var enemy))
            {
                return;
            }

            enemy.DealDamage(damage);
        }
    }