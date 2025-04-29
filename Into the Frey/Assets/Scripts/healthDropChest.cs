using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class healthDropChest : MonoBehaviour, IInteractable
{
    public bool IsOpened { get; private set; }
    public string ChestID { get; private set; }
    public GameObject itemPrefab;
    public Sprite closedSprite;
    public Sprite openedSprite;
    public float resetTime = 10f;

    private SpriteRenderer spriteRenderer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ChestID ??= GlobalHelper.GenerateUniqueID(gameObject);
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public bool CanInteract()
    {
        return !IsOpened;
    }

    public void Interact()
    {
        if (!CanInteract()) return;
        OpenChest();
    }

    private void OpenChest()
    {
        SetOpened(true);

        if (itemPrefab)
        {
            Instantiate(itemPrefab, transform.position + Vector3.down, Quaternion.identity);
        }

        StartCoroutine(ResetChestAfterDelay());
    }

    public void SetOpened(bool opened)
    {
        IsOpened = opened;
        if(spriteRenderer != null)
        {
            spriteRenderer.sprite = opened ? openedSprite : closedSprite;
        }
    }

    private IEnumerator ResetChestAfterDelay()
    {
        yield return new WaitForSeconds(resetTime);
        SetOpened(false);
    }
}
