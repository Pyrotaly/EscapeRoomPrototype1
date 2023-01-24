using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class GameManager : MonoBehaviour
{
    public TMPro.TextMeshProUGUI MainText;
    public Button Option1;
    public Button Option2;

    //static StoryBlock block1 = new StoryBlock(0, "You Just woke up in a small, dark cell in an old castle", "block1", "block2", 2, 4);
    //static StoryBlock block2 = new StoryBlock(1, "Waffles", "block4", "block5", 3, 5);
    //static StoryBlock block3 = new StoryBlock(2, "pLSNO", "block6", "nothing here", 6);
    //static StoryBlock block4 = new StoryBlock(3, "You Just woke up in a small, dark cell in an old castle", "A", "B");
    //static StoryBlock block5 = new StoryBlock(4, "You Just woke up in a small, dark cell in an old castle", "A", "B");
    //static StoryBlock block6 = new StoryBlock(5, "You Just woke up in a small, dark cell in an old castle");
    //Should have been an array with int representing the array

    //public StoryBlock[] StoryBlockArray = new StoryBlock[10];

    public ScriptableStoryBlock[] StoryBlockArray;
    private ScriptableStoryBlock currentBlock;
    //private StoryBlock currentBlock;

    private void Start()
    {
        DisplayBlock(0);
    }


    private void DisplayBlock(int i)
    {
        MainText.text = StoryBlockArray[i].NewStoryBlock.SStory;
        Option1.GetComponentInChildren<TMPro.TextMeshProUGUI>().text = StoryBlockArray[i].NewStoryBlock.SOption1Text;
        Option2.GetComponentInChildren<TMPro.TextMeshProUGUI>().text = StoryBlockArray[i].NewStoryBlock.SOption2Text;

        currentBlock = StoryBlockArray[i];
    }

    public void Button1Clicked()
    {
        DisplayBlock(currentBlock.NewStoryBlock.SOption1Block);
    }

    public void Button2Clicked()
    {
        DisplayBlock(currentBlock.NewStoryBlock.SOption2Block);
    }
}
