﻿using System;
using Core;
using PistonSimulation.PistonManagement;
using PistonSimulation.ReplacingManagement;
using UnityEngine;

namespace PistonSimulation
{
    public class GameManager : SingletonMono<GameManager>
    {
        public Action<BasePistonPiece> onPieceGrabbed;
        public Action<BasePistonPiece> onPieceReleased;
        
        public Action<BasePistonPiece> onPieceMounted;
        public Action<BasePistonPiece> onPieceUnmounted;

        public bool isAnimating;
        
        public Camera Cam => cam;
        
        [SerializeField]
        private Camera cam;


        public ReplaceManager ReplaceManager => replaceManager;

        [SerializeField]
        private ReplaceManager replaceManager;

        protected override void OnAwake()
        {
            PlayerPrefs.DeleteAll();
        }
    }
}