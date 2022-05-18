using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEditor.UIElements;


public class Board : MonoBehaviour
{

    DragAndDropManipulator manipulator;
    DragAndDropManipulator manipulator2;
    VisualElement root;
    public void Start()
    {
        // Each editor window contains a root VisualElement object
        root = GetComponent<UIDocument>().rootVisualElement;

        manipulator = new(root.Q<VisualElement>("Card1"));
        manipulator2 = new(root.Q<VisualElement>("Card2"));
        
        //Debug.Log(manipulator.ToString()); 

    }
}