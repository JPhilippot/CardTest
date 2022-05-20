using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEditor.UIElements;


public class UI : MonoBehaviour
{
    //[MenuItem("Window/UI Toolkit/UI")]
    /*  public static void ShowExample()
      {
          UI wnd = GetWindow<UI>();
          wnd.titleContent = new GUIContent("UI");
      }
  */
    DragAndDropManipulator dragAndDropManipulator;
    VisualElement root;
    public void Start()
    {
        root = GetComponent<UIDocument>().rootVisualElement;
        dragAndDropManipulator= new(root.Q<VisualElement>("LinearMovement"),root);
        InitDraggableChildren(root);

    }


    /// <summary>
    /// Search for any child having the "Draggable" class and make it draggable.
    /// [Can be improved]
    /// </summary>
    /// <param name="root"></param>
    void InitDraggableChildren(VisualElement root)
    {
        foreach (VisualElement element in root.Children())
        {
            Debug.Log("Reached : " + element.name);
            if (element.ClassListContains("Draggable"))
            {
                element.RegisterCallback<MouseEnterEvent, VisualElement>(SetTarget, element);
            }
            else
            {
                if (element.childCount > 0)
                {
                    InitDraggableChildren(element);
                }

            }
        }
    }
    void SetTarget(MouseEnterEvent evt,VisualElement target)
    {
        dragAndDropManipulator.SetTarget(target);
    }
}