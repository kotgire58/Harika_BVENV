# Behavior Trees & AI Decision-Making in Unity

## Overview
This project demonstrates a complete implementation of Behavior Trees for AI decision-making in Unity.  
It is built as a teaching resource as part of the **Take-Home Final: Teaching AI in Game Development** assignment.

The AI system includes:
- Patrol behavior using waypoints  
- Player detection using distance checks  
- Chase behavior using NavMeshAgent  
- Selector-based decision-making (Chase → Patrol fallback)  
- A clean modular Behavior Tree framework  

This project is designed to teach how modular AI systems are structured, evaluated, and integrated into Unity gameplay.

---

## Features
- Behavior Tree framework (Selector, Action Nodes, Node States)
- Patrol & Chase AI behaviors
- Unity NavMesh integration for movement
- Clear separation of decision logic and movement logic
- Well-organized codebase and folder structure
- Included educational materials:
  - Tutorial documentation
  - Pedagogical report
  - Diagrams
  - Exercises for students

---

## Project Structure

- If Chase conditions succeed → enemy chases the player.
- If Chase fails (e.g., player too far) → fallback to Patrol.

### Patrol Behavior
Enemy cycles through multiple waypoints in sequence.

### Chase Behavior
Enemy measures distance to the player and moves toward them when within the chase radius.

### NavMesh Integration
All enemy movement is handled using Unity’s built-in NavMeshAgent component.

---

## Setup Instructions
1. Clone or download the repository.
2. Open the project in **Unity 6000.xx or compatible version**.
3. Open the scene:
4. Assign:
- Player reference  
- Waypoints array  
- NavMeshAgent settings  
5. Press **Play** to test Patrol → Chase behavior.

---

## Documentation
The following educational materials are included in the `Documentation/` folder:

### Tutorial Documentation
- Theoretical foundations of Behavior Trees  
- Step-by-step Unity setup  
- Diagrams  
- Exercises  

### Pedagogical Report
- Teaching philosophy  
- Concept deep dive  
- Implementation analysis  
- Assessment strategy  
