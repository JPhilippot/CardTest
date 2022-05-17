using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEditor.UIElements;


public class Board : MonoBehaviour
{

    DragAndDropManipulator manipulator;
    VisualElement root;
    public void Start()
    {
        // Each editor window contains a root VisualElement object
        root = GetComponent<UIDocument>().rootVisualElement;
        manipulator = new(root.Q<VisualElement>("Card"));
        //Debug.Log(manipulator.ToString()); 

    }
}