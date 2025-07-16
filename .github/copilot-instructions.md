# Copilot Instructions for RimWorld Modding Project

## Mod Overview and Purpose

This RimWorld mod aims to enhance the gameplay experience by introducing a new set of behaviors for a custom creature known as the "Rimrat". The Rimrat mod focuses on adding depth and novelty to RimWorld's AI system, providing players with engaging and unpredictable interactions.

## Key Features and Systems

- **Curiosity Job System**: The mod introduces a new job giver, `JobGiver_Curiosity`, which empowers Rimrats to explore their environment driven by curiosity. This behavior is designed to make them more dynamic and less predictable.

- **Building Interaction**: Utilizing `RimratBuildingTrashUtility`, Rimrats can interact with certain structures, possibly leading to changes or disruptions. This makes the environment feel more alive and responsive to Rimrat presence.

- **Conditional Logic for Rimrats**: With `ThinkNode_ConditionalRimrat`, the behavior of Rimrats can be adjusted based on various conditions, creating more complex interaction patterns within the game world.

## Coding Patterns and Conventions

- **Class Naming**: Use PascalCase for class names (e.g., `JobGiver_Curiosity`, `ThinkNode_ConditionalRimrat`).

- **Method Naming**: Adopt camelCase for method names, reflecting their function (though no specific methods are currently documented, this aligns with C# conventions).

- **Static Classes**: Utilities that do not require instantiation should be implemented as static classes, like `RimratBuildingTrashUtility`.

## XML Integration

- **Error Handling**: The current XML files contain parsing errors. Ensure XML files are well-formed and validated to avoid runtime issues.

- **Mod Integration**: XML files typically define game assets, like Rimrat's characteristics or job definitions. Use XML Def files to complement C# scripts where customization of objects is needed.

## Harmony Patching

- **Purpose**: Harmony patches are crucial for modifying or extending RimWorld's core functionality without directly altering the original game code.

- **Implementation**: When using Harmony, create patches in a separate C# file, following the pattern of creating prefix, postfix, or transpiler methods as required. 

- **Conventions**: Use descriptive naming for Harmony patches to clearly indicate what original method is being affected and why.

## Suggestions for Copilot

- **Predictive Suggestions**: Copilot can be leveraged for auto-completing common method structures or accessing frequently used RimWorld API references.

- **Error Resolution**: Utilize Copilot to identify and fix potential errors or code inefficiencies, especially in XML files and during Harmony patching.

- **Code Comments**: Encourage Copilot to generate context-based comments that explain the purpose and logic of complex code segments, making the codebase easier to navigate for future contributors.

- **Pattern Recognition**: Enable Copilot to maintain consistency in coding patterns and naming conventions across the mod's development.

By adhering to these guidelines and utilizing Copilot effectively, you can streamline the development process while ensuring your mod is robust, compatible, and easy to maintain.
