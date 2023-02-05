using UnityEngine;
using UnityEngine.EventSystems;

public class urlTexto : MonoBehaviour, IPointerClickHandler, IEventSystemHandler{
	
	public string urlAAbrir;

	public void OnPointerClick(PointerEventData eventData) {
		Application.OpenURL(urlAAbrir);
	}

}