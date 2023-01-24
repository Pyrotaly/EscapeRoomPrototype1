using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "newTestStoryBlock", menuName = "TestStoryBlock")]
public class StoryBlock : ScriptableObject
{
    public string Story;
    public string Option1Text;
    public string Option2Text;
    public int Option1Block;
    public int Option2Block;
    public int BlockID;

    public StoryBlock(int BlockID, string Story, string Option1Text = "", string Option2Text = "",
        int Option1Block = 0, int Option2Block = 0)
    {
        this.BlockID = BlockID;
        this.Story = Story;
        this.Option1Text = Option1Text;
        this.Option2Text = Option2Text;
        this.Option1Block = Option1Block;
        this.Option2Block = Option2Block;
    }
}