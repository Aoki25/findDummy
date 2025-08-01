using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public string[] TextCall;
    public Sprite[] SpriteS;
    public string[] TextReasoning;
    public Sprite[] SpriteS_2;
    public int[] IValueS;
    public GameObject XVNWU;
    public GameObject XVNWU1;
    public GameObject XVNWU2;
    public GameObject XVNWU3;
    public GameObject Description1;
    public GameObject Description2;
    public GameObject xvnwuImage1;
    public GameObject xvnwuImage2;
    public GameObject xvnwuImage3;
    public FindObject FindObjectScript;

    private void Start()
    {
        var obj1_0 = this.XVNWU.GetComponent<Image>();
        obj1_0.sprite = this.SpriteS[0]; // 寻物页设置初始图片
        var obj1_1 = this.XVNWU1.GetComponent<Image>();
        obj1_1.sprite = this.SpriteS[1];
        var obj1_2 = this.XVNWU2.GetComponent<Image>();
        obj1_2.sprite = this.SpriteS[2];
        var obj1_3 = this.XVNWU3.GetComponent<Image>();
        obj1_3.sprite = this.SpriteS[3];
        var obj0_1 = this.Description1.GetComponent<TextMeshProUGUI>();//接到警情页
        obj0_1.text = this.TextCall[0]; // 设置初始文本
        var obj2_1 = this.Description2.GetComponent<TextMeshProUGUI>();//寻物描述页
        obj2_1.text = this.TextReasoning[0];
        var obj1_1_1 = this.xvnwuImage1.GetComponent<Image>();
        obj1_1_1.sprite = this.SpriteS_2[0]; // 设置寻物页图片
        var obj1_1_2 = this.xvnwuImage2.GetComponent<Image>();
        obj1_1_2.sprite = this.SpriteS_2[1]; // 设置寻物页图片
        var obj1_1_3 = this.xvnwuImage3.GetComponent<Image>();
        obj1_1_3.sprite = this.SpriteS_2[2]; // 设置寻物页图片
    }
    
}
