﻿using System;
using Newtonsoft.Json;
using UnityEngine;
using System.Collections.Generic;
using BattleTech;

namespace SalvageOperations
{
    internal class ModSettings
    {
        public float ReadyMechDelayFactor = 1f;
        public KeyCode Hotkey = KeyCode.Mouse0;
        public float CT_Value = 0.5f;
        public float Other_Parts_Value = 1 / 12f;
        public float Rounding_Cutoff = 0.75f;
        public bool SalvageValueUsesSellPrice = true;
        public bool ReplaceMechSalvageLogic = true;
        public List<MechDef> Variant_Exceptions = new List<MechDef>();

        public bool Debug = false;

        public static ModSettings ReadSettings(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<ModSettings>(json);
            }
            catch (Exception e)
            {
                Main.HBSLog.Log($"Reading settings failed: {e.Message}");
                return new ModSettings();
            }
        }
    }

}
