using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Configuracion : MonoBehaviour
{
	public Slider gen;

	public Slider mus;

	public Slider son;

	[HideInInspector]
	private Resolution[] resoluciones;

	public Dropdown resolucionDropdown;

	public float musNum;

	public float sonNum;

	private void Start()
	{
		gen.value = 0.5f;
		mus.value = 0.5f;
		son.value = 0.5f;
		resoluciones = new Resolution[3];
		int num = 1;
		for (int i = 0; i < resoluciones.Length; i++)
		{
			int num2 = num - 1;
			if (i % 2 == 0)
			{
				resoluciones[i].width = 1920 / num;
				resoluciones[i].height = 1080 / num;
				num++;
			}
			else
			{
				resoluciones[i].width = 3840 / (num + num2);
				resoluciones[i].height = 2160 / (num + num2);
			}
		}
		resolucionDropdown.ClearOptions();
		List<string> list = new List<string>();
		for (int j = 0; j < resoluciones.Length; j++)
		{
			string item = resoluciones[j].width + "x" + resoluciones[j].height;
			list.Add(item);
		}
		resolucionDropdown.AddOptions(list);
	}

	private void Update()
	{
		Volumen();
	}

	private void Volumen()
	{
		musNum = gen.value * mus.value;
		sonNum = gen.value * son.value;
	}

	public void CambiarResolucion(int resolucionIndex)
	{
		UnityEngine.Debug.Log("Es " + resolucionDropdown.value);
		Resolution resolution = resoluciones[resolucionDropdown.value];
		Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
	}
}
