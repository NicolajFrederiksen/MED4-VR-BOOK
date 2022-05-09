using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Demo : MonoBehaviour
{
    public BookController bookController;
    
    //[SerializeField]
    //Button nextButton;
    //[SerializeField]
    //Button previousButton;
    [SerializeField]
    Image bookImage;
    [SerializeField]
    Sprite bookTexture;
    [SerializeField]
    Sprite notepadTexture;

    

    public GameObject[] pages;

    int currentPage;
    View currentView;

   


    public enum View
    {
        Book,
        Notepad
    }

    void Start()
    {
        UpdatePage();
        
        //nextButton.onClick.AddListener(NextPage);
        //previousButton.onClick.AddListener(PreviousPage);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {

            NextPage();
      

        }

        if (Input.GetButtonDown("XRI_Right_TriggerButton") && currentPage < pages.Length-1)
        {

        
            NextPage();

        }
        if (Input.GetButtonDown("XRI_Left_TriggerButton") && currentPage > 0)
        {

         
            PreviousPage();

        }



    }

    public void SetBook(bool value)
    {
        SetView(value ? View.Book : View.Notepad);
    }

    void SetView(View value)
    {
        if (currentView == value) return;

        currentView = value;
        bookImage.sprite = currentView == View.Book ? bookTexture : notepadTexture;
    }

    void NextPage()
    {
        bookController.NextPage();
        currentPage = Mathf.Min(++currentPage, pages.Length - 1);
        StartCoroutine(UpdatePageDelayed());
    }

    void PreviousPage()
    {
        bookController.PreviousPage();
        currentPage = Mathf.Max(--currentPage, 0);
        StartCoroutine(UpdatePageDelayed());
    }
    
    IEnumerator UpdatePageDelayed()
    {
        yield return new WaitForEndOfFrame();
        UpdatePage();
    }



    void UpdatePage()
    {
        Array.ForEach(pages, c => { c.SetActive(false);});
        pages[currentPage].SetActive(true);
        
        //nextButton.gameObject.SetActive(currentPage < pages.Length - 1);
        //previousButton.gameObject.SetActive(currentPage > 0);
    }
}
