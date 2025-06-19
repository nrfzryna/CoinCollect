# 🕹️ Unity Coin Collection Mini Game

This is a simple Unity mini game where the player clicks a **Start** button, then controls a character to collect coins within a time limit. The game starts with a **Start Panel**, ends with an **End Panel**, and shows the player's score.

---

## ✅ Features Implemented

- 🟢 Start screen with **Start Button** to begin the game
- 🕒 In-game **timer** (e.g. 60 seconds)
- 🪙 Player can move and collect coins
- 🧾 Score increases with each coin collected
- 🔚 End screen with final score when time is up

---

## 🧠 Requirements

- Unity
- TextMeshPro (comes with Unity UI)
- A `Canvas` with:
  - Start Panel (`startPanel`)
  - End Panel (`endPanel`)
  - Text objects for score, timer, and end message
- A **Player** GameObject with:
  - Movement script (e.g. `Player.cs`)
  - Tagged as `"Player"`
- A **Coin** prefab with:
  - `Coin.cs` script
  - Collider set to `isTrigger`
- A `GameManager.cs` script to control UI logic and game state

---

## 🧩 Project Structure

| Component       | Purpose                                      |
|----------------|----------------------------------------------|
| `GameManager.cs` | Handles start, timer, end game, UI updates |
| `Coin.cs`        | Detects collision with player, adds score   |
| `Player.cs`      | Basic player movement                       |

---

## 🎮 How to Play

1. Run the scene.
2. Click the **Start** button on the Start Panel.
3. The player can now move around and collect coins.
4. When time runs out, the End Panel appears showing the score.

---

## 📌 To Do / Ideas for Expansion

- Add floating text (`+1`) when coin is collected
- Add sound effects and music
- Animate the start and end panels
- Add a restart button to replay the game
- Add jump or obstacles for more challenge

---

## 🛠 Setup Notes

- Make sure your Player has a Rigidbody and Collider
- Coins must have `isTrigger` checked
- Assign all public UI references (Text, Panels) to `GameManager` in the Inspector
- Set player tag to `"Player"`
