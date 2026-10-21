# GitHub Copilot Instructions for Rimrats (Continued) Mod

## Mod Overview and Purpose

**Mod Name:** Rimrats (Continued)  
**Original Author:** Oblivionburn  
**Current Maintainer:** [Your Name]

The Rimrats (Continued) mod enhances the existing gameplay of RimWorld by reintroducing and optimizing the rimrat creature from the pre-war times on the rimworlds. The focus is on providing an immersive experience where rimrats exhibit more dynamic behavior and specific interactions with the game environment, notably targeting power cables rather than buildings.

## Key Features and Systems

- **Dynamic Behavior:** Rimrats prioritize fleeing, eating, and carrying out basic tasks over attacking, retaining the creature's naturalistic traits.
- **Targeted Interactions:** Unlike the aggressive boomrat, rimrats specifically attack power cables, adding a unique pest element to gameplay.
- **Improved Textures:** Updated visual elements to enhance the immersion and visual quality of the mod.
- **Balancing Tamed Rimrats:** Once tamed, rimrats cease their attacks on power cables, providing a clear distinction between wild and domesticated rimrats.
- **Biome-def and Thinktree Integration Patches:** Biome and behavioral definitions have been optimized using XML patches for better integration and performance.

## Coding Patterns and Conventions

- Follow C# conventions with PascalCasing for method names and CamelCasing for local fields.
- Maintain consistency with naming of classes and methods to reflect their purpose, such as `JobGiver_Curiosity` and `RimratBuildingTrashUtility`.
- Keep methods concise, focusing on single responsibilities to ensure clean separation of concerns and easier readability.

## XML Integration

- Utilize XML files for defining specific mod elements:
  - `Races_Animal_Rimrat.xml` contains animal characteristics and specific rimrat behavior definitions.
  - `biome-patch.xml` and `thinktree-patch.xml` implement changes to native biomes and rimrat behavior trees, using RimWorld's patching conventions for XML definitions to avoid direct overrides.

## Harmony Patching

- Consider using Harmony to modify existing game methods non-destructively. This allows for dynamic adjustment of game functions affecting rimrats without directly altering original game code.
- Harmony patches should be well-documented within the codebase to indicate which classes and methods are being patched.

## Suggestions for Copilot

To generate code and content seamlessly with GitHub Copilot, consider the following suggestions:

1. **Brevity and Clarity:**
   - Write concise prompt comments before significant code sections to inform Copilot about the intended logic or system behavior.

2. **Descriptive Naming:**
   - Use descriptive variable and method names that convey their functionality clearly, assisting Copilot in predicting the continuation more accurately.

3. **Frequent Documentation:**
   - Regularly include XML styling comments for Copilot to understand the XML structure's intent and purpose, enhancing prediction accuracy for XML content creation.

4. **Pattern Reinforcement:**
   - Incorporate noticeable patterns in method implementations to help Copilot recognize and follow these coding patterns effectively in the same class or across similar ones.

By following these guidelines and suggestions, you can leverage GitHub Copilot to accelerate the development and maintenance of the Rimrats (Continued) mod while preserving high code-quality standards.

## Project Solution Guidelines
- Relevant mod XML files are included as Solution Items under the solution folder named XML, these can be read and modified from within the solution.
- Use these in-solution XML files as the primary files for reference and modification.
- The `.github/copilot-instructions.md` file is included in the solution under the `.github` solution folder, so it should be read/modified from within the solution instead of using paths outside the solution. Update this file once only, as it and the parent-path solution reference point to the same file in this workspace.
- When making functional changes in this mod, ensure the documented features stay in sync with implementation; use the in-solution `.github` copy as the primary file.
- In the solution is also a project called Assembly-CSharp, containing a read-only version of the decompiled game source, for reference and debugging purposes.
- For any new documentation, update this copilot-instructions.md file rather than creating separate documentation files.


## Hard rules (must follow)
- Do NOT run commands that modify the repo (no git commit, git apply, dotnet format) unless explicitly asked.
- Prefer minimal reads: read only the smallest code region needed (around the suspicious lines).
- When mentioning SonarQube issues, automatically use the SonarQube MCP service to fetch and address issues instead of making inferred fixes without querying SonarQube first.
- When mentioning the rimworld log, automatically use the Rimworld MCP service to fetch the log.

