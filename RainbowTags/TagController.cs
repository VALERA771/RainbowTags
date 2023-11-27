using System;
using System.Collections.Generic;
using Exiled.API.Features;
using MEC;
using UnityEngine;

namespace RainbowTags
{
    public class TagController : MonoBehaviour
    {
        private Player _player;
        private int _position;
        private int _intervalInFrames;
        private CoroutineHandle _coroutineHandle;
    
        public string[] Colors => Badge.Colors;

        public float Interval => Badge.ChangeTime;
        
        public RainbowBadge Badge { get; set; }
        
        private void Awake()
        {
            _player = Player.Get(gameObject);
            _intervalInFrames = Mathf.CeilToInt(Badge.ChangeTime) * 50;
        }
        
        private void Start()
        { 
            _coroutineHandle = Timing.RunCoroutine(UpdateColor().CancelWith(_player.GameObject));
        }
        
        private void OnDestroy()
        {
            Timing.KillCoroutines(_coroutineHandle);
        }
        
        private string RollNext()
        {
            var num = _position + 1;
            _position = num;
        
            if (num >= Colors.Length)
                _position = 0;
        
            if (Colors.Length == 0)
                return string.Empty;
        
            return Colors[_position];
        }
        
        private IEnumerator<float> UpdateColor()
        {
            for (; ; )
            {
                int num;
                for (int z = 0; z < _intervalInFrames; z = num + 1)
                {
                    yield return 0f;
                    num = z;
                }
                string text = RollNext();
                if (string.IsNullOrEmpty(text))
                {
                    break;
                }
                _player.RankColor = text;
            }
            Destroy(this);
        }
    }
}