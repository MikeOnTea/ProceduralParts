﻿using KSPAPIExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProceduralParts.Geometry
{
    public class ProceduralMesh
    {
        private UncheckedMesh _ColliderMesh;
        private UncheckedMesh _CapsMesh;
        private UncheckedMesh _SidesMesh;
        private float _Volume;

        public float Volume
        {
            get { return _Volume; }
        }

        public UncheckedMesh SidesMesh
        {
            get { return _SidesMesh; }
        }

        public UncheckedMesh CapsMesh
        {
            get { return _CapsMesh; }
        }

        public UncheckedMesh ColliderMesh
        {
            get { return _ColliderMesh; }
        }

        public ProceduralMesh(UncheckedMesh sidesMesh, UncheckedMesh capsMesh, UncheckedMesh colliderMesh, float volume)
        {
            _ColliderMesh = colliderMesh;
            _CapsMesh = capsMesh;
            _SidesMesh = sidesMesh;
            _Volume = volume;
        }
    }
}
