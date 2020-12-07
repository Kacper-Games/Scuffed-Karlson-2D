﻿using UnityEngine;
using UnityEngine.UI;

namespace LuigiStudio.Utility
{
	public class FPSCounter : MonoBehaviour
	{
		public Text fpsDisplay;

		void Update()
		{
			float fps = 1 / Time.unscaledDeltaTime;
			fpsDisplay.text = "FPS: " + fps;
		}
	}
}
