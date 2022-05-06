using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class StoryManager : MonoBehaviour
{


    public BookScript book;
    public TextMeshProUGUI pageTitel;
    public TextMeshProUGUI pageTextContent;
    public TextMeshProUGUI pageNumber;

    public Button backwardsButton;
    public Button forwardButton;

    public int pageIndex;


    //private void OnValidate()
    //{
    //    pageTitel.text = book.page[pageIndex].pageTitel.ToString();
    //    pageTextContent.text = book.page[pageIndex].pageText.ToString();
    //    pageNumber.text = pageIndex.ToString();
    //}

    private void Start()
    {
        pageTitel.text = book.page[pageIndex].pageTitel.ToString();
        pageTextContent.text = book.page[pageIndex].pageText.ToString();
        pageNumber.text = pageIndex.ToString();
    }


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if (book.page.Count-1 > pageIndex)
            {
                pageIndex++;
                Debug.Log("Turning page forward");
            }
            else
            {
                Debug.Log("Cannot turn page forward:  You are already on the last page");
            }
                

        }
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            if (pageIndex != 0)
            {
                pageIndex--;
                Debug.Log("Turning page backwards");
            }
            else
            {
                Debug.Log("Cannot turn page backwards: You are already on the first page");
            }
           
        }


        
            pageTitel.text = book.page[pageIndex].pageTitel.ToString();
            pageTextContent.text = book.page[pageIndex].pageText.ToString();
            pageNumber.text = pageIndex.ToString();
        
      
    }


    public void TurnPageBackwards()
    {
        if (pageIndex != 0)
        {
            pageIndex--;
            Debug.Log("Turning page backwards");
        }
        else
        {
            Debug.Log("Cannot turn page backwards: You are already on the first page");
        }
    }
    public void TurnPageForward()
    {
        if (book.page.Count - 1 > pageIndex)
        {
            pageIndex++;
            Debug.Log("Turning page forward");
        }
        else
        {
            Debug.Log("Cannot turn page forward:  You are already on the last page");
        }
    }
}
