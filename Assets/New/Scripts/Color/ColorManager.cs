using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PaintHit
{
    public class ColorManager : MonoBehaviour
    {
        [HideInInspector] public static ColorManager instance;

        [SerializeField] List<Color> colorList = new List<Color>();
        List<ColorData> _colorDataList = new List<ColorData>();

        private ColorData _currentColor;

        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }

            int randomIndex = Random.Range(0, _colorDataList.Count);
            GenerateColorData();
            _currentColor = _colorDataList[randomIndex];
        }

        private void Start()
        {
           
        }

        public ColorData GetCurrentColor()
        {
            return _currentColor;
        }

        public ColorData GetBallColor()
        {
            return _currentColor;
        }

        public List<Color> GetInitialCircleColors()
        {
            return new List<Color>();
        }

        private void GenerateColorData()
        {
            for (int i = 0; i < colorList.Count; i++)
            {
                ColorData data = new ColorData(colorList[i], i);
                _colorDataList.Add(data);
            }
           
        }
    }
}
