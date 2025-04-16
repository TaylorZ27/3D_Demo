using UnityEngine;

public class DiaryClicker : MonoBehaviour
{
    public GameObject[] canvases;  
    private int currentIndex = 0;

    public void ShowNextCanvas()
    {
        if (currentIndex < canvases.Length)
        {
            canvases[currentIndex].SetActive(true);
            currentIndex++;
        }
    }


    private void OnMouseDown()
    {
        ShowNextCanvas();
    }
}
