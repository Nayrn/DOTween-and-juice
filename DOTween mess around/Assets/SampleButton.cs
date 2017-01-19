using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using DG.Tweening;

public class SampleButton : MonoBehaviour
{
    public Button button;
    public Text nameLabel;
    public Text priceLabel;
    public Image iconImage;

    private Item item;
    private ShopScrollList scrollList;

    private Vector3 scale;
 

	// Use this for initialization
	void Start ()
    {
	    scale = new Vector3(1, 1, 0);
        transform.localScale = scale;

        button.onClick.AddListener(HandleClick);
	}

    // figure out how to use DOTween with UI and not just objects

    public void SetUp(Item currentItem, ShopScrollList currentScrollList)
    {
        item = currentItem;
        nameLabel.text = item.itemName;
        priceLabel.text = item.price.ToString();
        iconImage.sprite = item.icon;
        scrollList = currentScrollList;
    }

    public void HandleClick()
    {
        scrollList.TryTransferItemToOtherShop(item);
    }
}
