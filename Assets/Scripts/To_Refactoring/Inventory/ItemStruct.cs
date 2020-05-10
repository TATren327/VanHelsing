﻿using System;
using UnityEngine;


namespace BeastHunter
{
    [Serializable]
    public struct ItemStruct
    {
        public string Name;
        public string Discription;

        public SlotSize SlotSize;
        public ItemType ItemType;

        public Mesh MeshOfObject;
        //public Image Icon;
    }
}

