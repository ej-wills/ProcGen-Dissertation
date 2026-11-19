using System;
using System.Collections.Generic;
using UnityEngine;



public abstract class Node
{
    private List<Node> childrenNodeList;
    public List<Node> ChildrenNOdeList { get => childrenNodeList; }

    public bool Visited { get; set; }

    public Vector2Int BottomLeftAreaCorner { get; set; }
    public Vector2Int BottomRightAreaCorner { get; set; }
    public Vector2Int TopLeftAreaCorner { get; set; }
    public Vector2Int TopRightAreaCorner { get; set; }
    public Node parent {  get; set; }

    public int TreeLayerIndex { get; set; }


    protected Node(Node parentNode)
    {
        childrenNodeList = new List<Node>();
        this.parent = parentNode;
        if (parentNode != null)
        {
            parentNode.AddChild(this);
        }
        
    }

    private void AddChild(Node node)
    {
       childrenNodeList.Add(node);
    }


    private void RemoveChild(Node node)
    {
        childrenNodeList.Remove(node);
    }
}