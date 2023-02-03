using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddOnde : MonoBehaviour
{
    public GameObject nodePrefab;
    private BinaryTree binaryTree;
    public int numberofNodes;
    private bool rotado;
    


    public static List<int> GenerateRandomNumbers(int count)
    {
        List<int> numbers = new List<int>();
        for (var index = 0; index < count; index++)
            numbers.Add(index);
   
        List<int> results = new List<int>();
        while (numbers.Count > 0)
        {
            int position = Random.Range(0, numbers.Count);
 
            results.Add(numbers[position]);
            numbers.RemoveAt(position);
        }
 
        return results;
    }

    private void Start()
    {
        binaryTree = new BinaryTree();

        
    foreach(var number in GenerateRandomNumbers(numberofNodes))
    {

            binaryTree.AddNode(number, new Vector3(0, 0, 0), Quaternion.identity);
    }
        binaryTree.InstantiateNodes(nodePrefab);
    }
 

}
