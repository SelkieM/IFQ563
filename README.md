# IFQ563
Object Orientated Design 
Object-Oriented Tic-Tac-Toe 🎮
This C# application is a fully object-oriented implementation of Tic-Tac-Toe (3x3), designed to demonstrate principles of modularity, extensibility, and software design patterns. The first player to align three pieces horizontally, vertically, or diagonally wins.

🧠 Key Features:
Game Modes:

Human vs Human
Human vs Computer (with selectable AI strategy)

AI Strategies:

Random valid move selection
Alpha-Beta pruning algorithm with a custom board evaluation function

Game Management:

Validates all human input for legal moves
Supports saving and loading game states
Undo and redo functionality
Replay any game from any point in its move history

User Assistance:

Basic online help system to guide user interactions and commands

🧱 Object-Oriented Design:

Built with extensibility in mind to support future board games with minimal code duplication.
Uses inheritance and interfaces to abstract common game components (e.g., Player, Board, GameState).
Clean separation of concerns between UI, game logic, and AI components.
Demonstrates use of design patterns such as Strategy (for AI) and Memento (for game history).
This project was created to meet the objectives of a software development assignment focused on real-world, object-oriented application design using C#. It serves as a framework that can be extended to implement other two-player board games.
