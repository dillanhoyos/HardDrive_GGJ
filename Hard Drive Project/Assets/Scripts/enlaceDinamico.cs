// using Firebase.Database;
// using UnityEngine;

// public class enlaceDinamico : MonoBehaviour
// {
// 	public static enlaceDinamico enlaceDinamicoSingleton;
// 	private DatabaseReference reference;
// 	public string nombreALeer, enlaceProvisional;
// 	private string enlace;
// 	private bool retorno;
	
// 	private void Awake()
// 	{
// 		if (enlaceDinamicoSingleton == null)
// 		{
// 			enlaceDinamicoSingleton = this;
// 			Object.DontDestroyOnLoad(base.gameObject);
// 			enlaceDinamicoSingleton.reference = null;
// 		}
// 		else
// 		{
// 			UnityEngine.Object.Destroy(base.gameObject);
// 		}
// 	}

// 	private void Start()
// 	{
// 		if (enlaceDinamicoSingleton.reference == null)
// 		{
// 			enlaceDinamicoSingleton.reference = FirebaseDatabase.DefaultInstance.RootReference;
// 		}
// 	}

// 	public bool abrirEnlaceDinamico()
// 	{
//         /* 
// 		enlaceDinamicoSingleton.reference.Child("enlacesDinamicos").Child(enlaceDinamicoSingleton.nombreALeer).GetValueAsync()
// 			.ContinueWith(delegate(Task<DataSnapshot> task)
// 			{
// 				if (task.IsCompleted)
// 				{
// 					DataSnapshot result = task.Result;
// 					enlaceDinamicoSingleton.enlace = result.Child("Enlace").Value.ToString();
// 					enlaceDinamicoSingleton.retorno = true;
// 				}
// 				else
// 				{*/
// 					enlaceDinamicoSingleton.retorno = false;
// 				/*}
// 			});

// 		*/
//         return enlaceDinamicoSingleton.retorno;
// 	}

// 	public string getEnlace() {
// 		return enlaceDinamicoSingleton.enlace;
// 	}

// }