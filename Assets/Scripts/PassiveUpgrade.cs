using TMPro;
using UnityEngine;
using UnityEngine.UI;
using BreakInfinity;

public class PassiveUpgrade : MonoBehaviour
{
    public TextMeshProUGUI upgradeText; // Drag your UI element for showing upgrade level here
    public TextMeshProUGUI upgradeCostText; // Drag your UI element for showing cost here
    public Button purchaseButton; // Drag the button here in the Inspector

    public TextMeshProUGUI upgradeText2; // Drag your UI element for showing upgrade level here
    public TextMeshProUGUI upgradeCostText2; // Drag your UI element for showing cost here
    public Button purchaseButton2; // Drag the button here in the Inspector
    public BigDouble upgradeLevel2 = 0;
    public BigDouble upgradeCost2 = 10f;

    public TextMeshProUGUI upgradeText3; // Drag your UI element for showing upgrade level here
    public TextMeshProUGUI upgradeCostText3; // Drag your UI element for showing cost here
    public Button purchaseButton3; // Drag the button here in the Inspector
    public BigDouble upgradeLevel3 = 0;
    public float upgradeCost3 = 100f;

    public TextMeshProUGUI upgradeText4; // Drag your UI element for showing upgrade level here
    public TextMeshProUGUI upgradeCostText4; // Drag your UI element for showing cost here
    public Button purchaseButton4; // Drag the button here in the Inspector
    public BigDouble upgradeLevel4 = 0;
    public float upgradeCost4 = 100f;

    public TextMeshProUGUI upgradeText5; // Drag your UI element for showing upgrade level here
    public TextMeshProUGUI upgradeCostText5; // Drag your UI element for showing cost here
    public Button purchaseButton5; // Drag the button here in the Inspector
    public BigDouble upgradeLevel5 = 0;
    public float upgradeCost5 = 100f;

    public BigDouble upgradeLevel = 0; // Current level of the upgrade
    public float upgradeCost = 10f; // Initial cost of the upgrade
    private float costMultiplier = 1.15f; // Cost scaling factor

    public GameManager gameManager; // Reference to your GameManager script

    private float entropyGainInterval = 1f; // Time interval for passive entropy gain
    private int entropyGainAmount = 1; // Amount of entropy gained per interval
    private float nextEntropyGainTime = 0f; // Time for the next entropy gain

    public BigDouble upgradeLevel6 = 0;
    public float upgradeCost6 = 100f;

    public BigDouble upgradeLevel7 = 0;
    public float upgradeCost7 = 100f;

    public BigDouble upgradeLevel8 = 0;
    public float upgradeCost8 = 100f;

    public BigDouble upgradeLevel9 = 0;
    public float upgradeCost9 = 100f;

    public BigDouble upgradeLevel10 = 0;
    public float upgradeCost10 = 100f;

    public TextMeshProUGUI upgradeText6; // Drag your UI element for showing upgrade level here
    public TextMeshProUGUI upgradeCostText6; // Drag your UI element for showing cost here
    public Button purchaseButton6; // Drag the button here in the Inspector

    public TextMeshProUGUI upgradeText7; // Drag your UI element for showing upgrade level here
    public TextMeshProUGUI upgradeCostText7; // Drag your UI element for showing cost here
    public Button purchaseButton7; // Drag the button here in the Inspector

    public TextMeshProUGUI upgradeText8; // Drag your UI element for showing upgrade level here
    public TextMeshProUGUI upgradeCostText8; // Drag your UI element for showing cost here
    public Button purchaseButton8; // Drag the button here in the Inspector

    public TextMeshProUGUI upgradeText9; // Drag your UI element for showing upgrade level here
    public TextMeshProUGUI upgradeCostText9; // Drag your UI element for showing cost here
    public Button purchaseButton9; // Drag the button here in the Inspector

    public TextMeshProUGUI upgradeText10; // Drag your UI element for showing upgrade level here
    public TextMeshProUGUI upgradeCostText10; // Drag your UI element for showing cost here
    public Button purchaseButton10; // Drag the button here in the Inspector

    void Start()
    {
        purchaseButton.onClick.AddListener(BuyUpgrade);
        purchaseButton2.onClick.AddListener(BuyUpgrade2);
        purchaseButton3.onClick.AddListener(BuyUpgrade3);
        purchaseButton4.onClick.AddListener(BuyUpgrade4);
        purchaseButton5.onClick.AddListener(BuyUpgrade5);
        purchaseButton6.onClick.AddListener(BuyUpgrade6);
        purchaseButton7.onClick.AddListener(BuyUpgrade7);
        purchaseButton8.onClick.AddListener(BuyUpgrade8);
        purchaseButton9.onClick.AddListener(BuyUpgrade9);
        purchaseButton10.onClick.AddListener(BuyUpgrade10);
    }

    void Update()
    {
        // Check if it's time to add entropy passively
        if (Time.time >= nextEntropyGainTime && (upgradeLevel > 0 || upgradeLevel2 > 0 || upgradeLevel3 > 0 || upgradeLevel4 > 0 || upgradeLevel5 > 0 || upgradeLevel6 > 0 || upgradeLevel7 > 0 || upgradeLevel8 > 0 || upgradeLevel9 > 0 || upgradeLevel10 > 0))
        {
            upgradeLevel9 += entropyGainAmount * upgradeLevel10;
            upgradeLevel8 += entropyGainAmount * upgradeLevel9;
            upgradeLevel7 += entropyGainAmount * upgradeLevel8;
            upgradeLevel6 += entropyGainAmount * upgradeLevel7;
            upgradeLevel5 += entropyGainAmount * upgradeLevel6;
            upgradeLevel4 += entropyGainAmount * upgradeLevel5;
            upgradeLevel3 += entropyGainAmount * upgradeLevel4;
            upgradeLevel2 += entropyGainAmount * upgradeLevel3;
            upgradeLevel += entropyGainAmount * upgradeLevel2;
            gameManager.entropy += entropyGainAmount * upgradeLevel; 
            gameManager.UpdateUI(); // Update the UI to reflect new entropy
            UpdateUI();
            nextEntropyGainTime = Time.time + entropyGainInterval;
        }
    }


    void BuyUpgrade()
    {
        if (gameManager.entropy >= upgradeCost)
        {
            gameManager.entropy -= upgradeCost; // Deduct the cost
            upgradeLevel += 1; // Increment the upgrade level
            upgradeCost *= costMultiplier; // Increase the cost for the next level
            UpdateUI(); // Update the UI to reflect the new state
            gameManager.UpdateUI(); // Update the main game UI
        }
    }

    void BuyUpgrade2()
        {
            if (gameManager.entropy >= upgradeCost2)
            {
                gameManager.entropy -= upgradeCost2; // Deduct the cost
                upgradeLevel2 += 1; // Increment the upgrade level
                upgradeCost2 *= costMultiplier; // Increase the cost for the next level
                UpdateUI(); // Update the UI to reflect the new state
                gameManager.UpdateUI(); // Update the main game UI
            }
        }

    void BuyUpgrade3()
        {
            if (gameManager.entropy >= upgradeCost3)
            {
                gameManager.entropy -= upgradeCost3; // Deduct the cost
                upgradeLevel3 += 1; // Increment the upgrade level
                upgradeCost3 *= costMultiplier; // Increase the cost for the next level
                UpdateUI(); // Update the UI to reflect the new state
                gameManager.UpdateUI(); // Update the main game UI
            }
        }

    void BuyUpgrade4()
        {
            if (gameManager.entropy >= upgradeCost4)
            {
                gameManager.entropy -= upgradeCost4; // Deduct the cost
                upgradeLevel4 += 1; // Increment the upgrade level
                upgradeCost4 *= costMultiplier; // Increase the cost for the next level
                UpdateUI(); // Update the UI to reflect the new state
                gameManager.UpdateUI(); // Update the main game UI
            }
        }

    void BuyUpgrade5()
        {
            if (gameManager.entropy >= upgradeCost5)
            {
                gameManager.entropy -= upgradeCost5; // Deduct the cost
                upgradeLevel5 += 1; // Increment the upgrade level
                upgradeCost5 *= costMultiplier; // Increase the cost for the next level
                UpdateUI(); // Update the UI to reflect the new state
                gameManager.UpdateUI(); // Update the main game UI
            }
        }

    void BuyUpgrade6()
    {
        if (gameManager.entropy >= upgradeCost6)
        {
            gameManager.entropy -= upgradeCost6;
            upgradeLevel6 += 1;
            upgradeCost6 *= costMultiplier;
            UpdateUI();
            gameManager.UpdateUI();
        }
    }

    void BuyUpgrade7()
    {
        if (gameManager.entropy >= upgradeCost7)
        {
            gameManager.entropy -= upgradeCost7;
            upgradeLevel7 += 1;
            upgradeCost7 *= costMultiplier;
            UpdateUI();
            gameManager.UpdateUI();
        }
    }

    void BuyUpgrade8()
    {
        if (gameManager.entropy >= upgradeCost8)
        {
            gameManager.entropy -= upgradeCost8;
            upgradeLevel8 += 1;
            upgradeCost8 *= costMultiplier;
            UpdateUI();
            gameManager.UpdateUI();
        }
    }

    void BuyUpgrade9()
    {
        if (gameManager.entropy >= upgradeCost9)
        {
            gameManager.entropy -= upgradeCost9;
            upgradeLevel9 += 1;
            upgradeCost9 *= costMultiplier;
            UpdateUI();
            gameManager.UpdateUI();
        }
    }

    void BuyUpgrade10()
    {
        if (gameManager.entropy >= upgradeCost10)
        {
            gameManager.entropy -= upgradeCost10;
            upgradeLevel10 += 1;
            upgradeCost10 *= costMultiplier;
            UpdateUI();
            gameManager.UpdateUI();
        }
    }

    public void UpdateUI()
    {
        string formattedUpgradeLevel = BigDoubleFormatter.FormatBigDouble(upgradeLevel);
        string formattedUpgradeCost = BigDoubleFormatter.FormatBigDouble(upgradeCost);
        upgradeText.text = $"{formattedUpgradeLevel}";
        upgradeCostText.text = $"{formattedUpgradeCost}λ";

        string formattedUpgradeLevel2 = BigDoubleFormatter.FormatBigDouble(upgradeLevel2);
        string formattedUpgradeCost2 = BigDoubleFormatter.FormatBigDouble(upgradeCost2);
        upgradeText2.text = $"{formattedUpgradeLevel2}";
        upgradeCostText2.text = $"{formattedUpgradeCost2}λ";

        string formattedUpgradeLevel3 = BigDoubleFormatter.FormatBigDouble(upgradeLevel3);
        string formattedUpgradeCost3 = BigDoubleFormatter.FormatBigDouble(upgradeCost3);
        upgradeText3.text = $"{formattedUpgradeLevel3}";
        upgradeCostText3.text = $"{formattedUpgradeCost3}λ";

        string formattedUpgradeLevel4 = BigDoubleFormatter.FormatBigDouble(upgradeLevel4);
        string formattedUpgradeCost4 = BigDoubleFormatter.FormatBigDouble(upgradeCost4);
        upgradeText4.text = $"{formattedUpgradeLevel4}";
        upgradeCostText4.text = $"{formattedUpgradeCost4}λ";

        string formattedUpgradeLevel5 = BigDoubleFormatter.FormatBigDouble(upgradeLevel5);
        string formattedUpgradeCost5 = BigDoubleFormatter.FormatBigDouble(upgradeCost5);
        upgradeText5.text = $"{formattedUpgradeLevel5}";
        upgradeCostText5.text = $"{formattedUpgradeCost5}λ";

        string formattedUpgradeLevel6 = BigDoubleFormatter.FormatBigDouble(upgradeLevel6);
        string formattedUpgradeCost6 = BigDoubleFormatter.FormatBigDouble(upgradeCost6);
        upgradeText6.text = $"{formattedUpgradeLevel6}";
        upgradeCostText6.text = $"{formattedUpgradeCost6}λ";

        string formattedUpgradeLevel7 = BigDoubleFormatter.FormatBigDouble(upgradeLevel7);
        string formattedUpgradeCost7 = BigDoubleFormatter.FormatBigDouble(upgradeCost7);
        upgradeText7.text = $"{formattedUpgradeLevel7}";
        upgradeCostText7.text = $"{formattedUpgradeCost7}λ";

        string formattedUpgradeLevel8 = BigDoubleFormatter.FormatBigDouble(upgradeLevel8);
        string formattedUpgradeCost8 = BigDoubleFormatter.FormatBigDouble(upgradeCost8);
        upgradeText8.text = $"{formattedUpgradeLevel8}";
        upgradeCostText8.text = $"{formattedUpgradeCost8}λ";

        string formattedUpgradeLevel9 = BigDoubleFormatter.FormatBigDouble(upgradeLevel9);
        string formattedUpgradeCost9 = BigDoubleFormatter.FormatBigDouble(upgradeCost9);
        upgradeText9.text = $"{formattedUpgradeLevel9}";
        upgradeCostText9.text = $"{formattedUpgradeCost9}λ";

        string formattedUpgradeLevel10 = BigDoubleFormatter.FormatBigDouble(upgradeLevel10);
        string formattedUpgradeCost10 = BigDoubleFormatter.FormatBigDouble(upgradeCost10);
        upgradeText10.text = $"{formattedUpgradeLevel10}";
        upgradeCostText10.text = $"{formattedUpgradeCost10}λ";
    }
}
