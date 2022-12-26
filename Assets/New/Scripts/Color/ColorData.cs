using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PaintHit
{
    public class ColorData
    {
        public Color color;
        public int id;

        public ColorData(Color _color, int _id)
        {
            this.color = _color;
            this.id = _id;
        }
    }

}
