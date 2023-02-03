using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class trianglespawn : MonoBehaviour
{
   
     public GameObject prefab; // Assign prefab in the Inspector
    public float distanceBetweenPrefabs = 1f; // Distance between each prefab
    public int triangleSideLength = 10; // Number of prefabs on each side of the triangle

    private void Start()
    {
        // Parent container to keep all the instantiated prefabs organized in the hierarchy
        GameObject parentContainer =  this.gameObject;

        // Calculate the height of the equilateral triangle
        float triangleHeight = Mathf.Sqrt(3f) / 2f * distanceBetweenPrefabs * triangleSideLength;

        // Loop through the number of prefabs on each side of the triangle
        for (int i = 0; i < triangleSideLength; i++)
        {
            // Loop through the number of prefabs in each row
            for (int j = 0; j <= i; j++)
            {
                // Calculate the position of each prefab
                float xPos = j * distanceBetweenPrefabs - i * distanceBetweenPrefabs / 2;
                float zPos = -i * triangleHeight / 2;

                // Instantiate the prefab at the calculated position
                GameObject newPrefab = Instantiate(prefab, new Vector3(xPos, 0, zPos), Quaternion.identity);

                // Set the parent of the instantiated prefab to the parent container
                newPrefab.transform.SetParent(parentContainer.transform);
            }
        }
    }
}


