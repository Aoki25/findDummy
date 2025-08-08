using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager: MonoBehaviour
{
    public string[] TextCall;
    public Sprite[] SpriteS;
    public string[] TextReasoning;
    public Sprite[] SpriteS_2;
    public int[] IValueS;
    public string[] TestTuili;
    public string[] TestZhengci;
    public Sprite[] SpriteXianyiren;
    public Sprite[] DanganImage;
    [Multiline]
    public string[] DanganText;

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
    public GameObject tuili1;
    public GameObject tuili2;
    public GameObject tuili3;
    public GameObject zhengci1;
    public GameObject zhengci2;
    public GameObject zhengci3;
    public GameObject zhengci4;
    public GameObject xianyiren1;
    public GameObject xianyiren2;
    public GameObject xianyiren3;
    public GameObject xianyiren4;
    public GameObject DanganImage1;
    public GameObject DangangText1;

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
        var obj3_1 = this.tuili1.GetComponent<TextMeshProUGUI>();
        obj3_1.text = this.TestTuili[0]; // 设置推理页文本
        var obj3_2 = this.tuili2.GetComponent<TextMeshProUGUI>();
        obj3_2.text = this.TestTuili[1]; // 设置推理页文本
        var obj3_3 = this.tuili3.GetComponent<TextMeshProUGUI>();
        obj3_3.text = this.TestTuili[2]; // 设置推理页文本
        var obj4_1 = this.zhengci1.GetComponent<TextMeshProUGUI>();
        obj4_1.text = this.TestZhengci[0]; // 设置证词页文本
        var obj4_2 = this.zhengci2.GetComponent<TextMeshProUGUI>();
        obj4_2.text = this.TestZhengci[1]; // 设置证词页文本
        var obj4_3 = this.zhengci3.GetComponent<TextMeshProUGUI>();
        obj4_3.text = this.TestZhengci[2]; // 设置证词页文本
        var obj4_4 = this.zhengci4.GetComponent<TextMeshProUGUI>();
        obj4_4.text = this.TestZhengci[3]; // 设置证词页文本
        var obj4_1_1 = this.xianyiren1.GetComponent<Image>();
        obj4_1_1.sprite = this.SpriteXianyiren[0]; // 设置嫌疑人页图片
        var obj4_1_2 = this.xianyiren2.GetComponent<Image>();
        obj4_1_2.sprite = this.SpriteXianyiren[1]; // 设置嫌疑人页图片
        var obj4_1_3 = this.xianyiren3.GetComponent<Image>();
        obj4_1_3.sprite = this.SpriteXianyiren[2]; // 设置嫌疑人页图片
        var obj4_1_4 = this.xianyiren4.GetComponent<Image>();
        obj4_1_4.sprite = this.SpriteXianyiren[3]; // 设置嫌疑人页图片
        var obj5_1 = this.DanganImage1.GetComponent<Image>();
        obj5_1.sprite = this.DanganImage[0]; // 设置档案页图片
        var obj5_2 = this.DangangText1.GetComponent<TextMeshProUGUI>();
        obj5_2.text = this.DanganText[0]; // 设置档案页文本

    }
    
}
