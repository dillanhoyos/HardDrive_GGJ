using UnityEngine;
using UnityEngine.SceneManagement;

public class Control : MonoBehaviour {

	public GameObject Confi;
	protected static bool juegoPausado;
	public AudioSource musica;

	public void irAMenu()
	{
		Time.timeScale = 1f;
		SceneManager.LoadScene(0);
	}

	public void irANivel1()
	{
		Time.timeScale = 1f;
		SceneManager.LoadScene(2);
	}

	public void reiniciar()
	{
		Time.timeScale = 1f;
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

	public void irACreditos()
	{
		Time.timeScale = 1f;
		SceneManager.LoadScene(3);
	}

	public void irAInstrucciones()
	{
		Time.timeScale = 1f;
		SceneManager.LoadScene(4);
	}

	public void irANiveles()
	{
		Time.timeScale = 1f;
		SceneManager.LoadScene(5);
	}

	public void salir()
	{
		Application.Quit();
	}

	public void goURL(string URL)
	{
		Application.OpenURL(URL);
	}

	public void AbrirUI(GameObject objectCanva)
	{
		juegoPausado = true;
		objectCanva.SetActive(value: true);
		Time.timeScale = 0f;
	}

	public void CerrarUI(GameObject objectCanva)
	{
		juegoPausado = false;
		objectCanva.SetActive(value: false);
		Time.timeScale = 1f;
	}
}
