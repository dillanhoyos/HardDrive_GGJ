using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BinaryTree
{
    private class Node
    {
        public int value;
        public Vector3 position;
        public Quaternion rotation;
        public Node left;
        public Node right;

        public Node(int value, Vector3 position, Quaternion rotation)
        {
            this.value = value;
            this.position = position;
            this.rotation = rotation;
        }
    }

    private Node root;
    private float rotationAngle = 45.0f;
    private float separation = 1.0f;

    public void AddNode(int value, Vector3 position, Quaternion rotation)
    {
        Node newNode = new Node(value, position, rotation);

        if (root == null)
        {
            root = newNode;
            return;
        }

        Node currentNode = root;
        while (true)
        {
            if (value < currentNode.value)
            {
                if (currentNode.left == null)
                {
                    currentNode.left = newNode;
                    newNode.position = currentNode.position + (currentNode.rotation * Vector3.forward * -separation);
                    newNode.rotation = Quaternion.Euler(0, -rotationAngle, 0) * currentNode.rotation;
                    return;
                }
                currentNode = currentNode.left;
            }
            else
            {
                if (currentNode.right == null)
                {
                    currentNode.right = newNode;
                    newNode.position = currentNode.position + (currentNode.rotation * Vector3.forward * separation);
                    newNode.rotation = Quaternion.Euler(0, rotationAngle, 0) * currentNode.rotation;
                    return;
                }
                currentNode = currentNode.right;
            }
        }
    }

    public void InstantiateNodes(GameObject nodePrefab)
    {
        InstantiateNode(root, nodePrefab);
    }

    private void InstantiateNode(Node node, GameObject nodePrefab)
    {
        if (node == null)
        {
            return;
        }

        GameObject newObject = GameObject.Instantiate(nodePrefab, node.position, node.rotation);
        newObject.GetComponent<NodeVisual>().value = node.value;

        InstantiateNode(node.left, nodePrefab);
        InstantiateNode(node.right, nodePrefab);
    }
}