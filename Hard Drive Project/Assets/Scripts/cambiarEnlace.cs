using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

public class cambiarEnlace : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
{
	public string enlaceEstatico, nombreEnBDs;

	private bool enlaceDinFunc;

	public void OnPointerClick(PointerEventData eventData)
	{
		enlaceDinamico.enlaceDinamicoSingleton.nombreALeer = nombreEnBDs;
		enlaceDinamico.enlaceDinamicoSingleton.enlaceProvisional = enlaceEstatico;
		enlaceDinFunc = enlaceDinamico.enlaceDinamicoSingleton.abrirEnlaceDinamico();
		StartCoroutine(esperar(0.7f));
	}

	private IEnumerator esperar(float tiempo)
	{
		yield return new WaitForSeconds(tiempo);
		Application.OpenURL(enlaceDinamico.enlaceDinamicoSingleton.getEnlace());
	}
}
