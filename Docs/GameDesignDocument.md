# Atlas Unwritten

## Game Design Document (Version 1.0)

> **Purpose:** This document describes the design vision of Atlas Unwritten. It focuses on the intended player experience, gameplay systems, progression, and overall game design. Technical implementation details are intentionally omitted and are documented separately within the Technical Design Journal.

---

# Project Overview

Atlas Unwritten is a third-person exploration and scientific documentation game developed in Unreal Engine using C++.

Inspired by the sense of discovery found in _New Pokémon Snap_, Atlas Unwritten reimagines photography-based exploration as a free-roaming experience. Rather than travelling along a predetermined path, players are free to explore a handcrafted environment at their own pace, documenting the world through photography and contributing meaningful discoveries to an ongoing scientific expedition.

Players assume the role of a newly assigned field researcher joining an established expedition. While experienced specialists remain at Base Camp analysing discoveries, the player ventures into unexplored environments, gathering evidence through photography and gradually expanding the expedition's understanding of the world.

Unlike traditional exploration games, progression is not driven by combat, experience points, collectibles, or score systems. Instead, the player's discoveries contribute to a living scientific Atlas that grows alongside the expedition's collective knowledge. Every meaningful photograph has the potential to answer existing questions, generate new research, and encourage further exploration.

The first vertical slice takes place within a compact handcrafted desert environment. Although Atlas Unwritten may expand into additional expeditions in the future, development remains focused on completing a polished and self-contained desert experience before considering further environments.

---

# Core Philosophy

Atlas Unwritten is built upon one central philosophy:

> **Photography is not the goal. Photography is the tool used to create knowledge.**

Every mechanic within the game exists to reinforce this idea. The player is not rewarded simply for taking photographs, but for contributing meaningful scientific evidence that expands the expedition's understanding of the world.

Knowledge is the primary form of progression. Every accepted discovery should leave both the player and the expedition knowing something they did not know before.

---

# Player Experience Goals

Every system within Atlas Unwritten should contribute towards the following player experience goals.

## Become Part of an Expedition

The player should feel like an important member of a scientific expedition rather than a lone adventurer. Their role is to gather evidence while specialists continue the research back at Base Camp.

---

## Curiosity Should Drive Exploration

Players should naturally become curious about unusual landmarks, wildlife, plants, geological formations, and archaeological discoveries. Exploration should be motivated by the desire to understand the world rather than complete objectives.

---

## Every Discovery Should Feel Meaningful

Discoveries should never feel disposable. Every accepted photograph contributes to the expedition's research and permanently expands the Atlas.

---

## Research Should Feel Rewarding

Specialist observations should make players feel as though they are genuinely learning about the environment rather than simply unlocking additional content. The reward for exploration is understanding.

---

## The World Should Feel Alive

The expedition should continue functioning while the player explores. Specialists analyse discoveries over time, research develops naturally, and the Atlas continually grows to reflect the expedition's increasing knowledge of the environment.

---

# Design Pillars

Every feature implemented within Atlas Unwritten should support one or more of the following design pillars.

## Exploration

Players should feel encouraged to investigate the world around them. Curiosity should naturally lead them towards new discoveries, whether that is beyond the next sand dune, inside a forgotten cave, or among the ruins of an ancient civilisation.

Exploration should never feel rushed. The player is encouraged to slow down, observe their surroundings, and appreciate the environment.

---

## Observation

Observation is the player's greatest skill.

Success comes from noticing details within the environment rather than defeating enemies or overcoming mechanical challenges. Small visual differences, unusual behaviours, and environmental clues should encourage players to stop, investigate, and document what they discover.

---

## Scientific Discovery

Every accepted photograph should contribute towards a greater understanding of the world.

Rather than collecting photographs for completion alone, players gradually help answer scientific questions through repeated observation and documentation.

Research is collaborative. The player gathers evidence while specialists analyse discoveries and develop new hypotheses.

---

## Collaboration

The player is only one member of a larger scientific expedition.

While the player explores the environment, specialists remain at Base Camp researching discoveries, documenting observations, and expanding the Atlas. Their work gives meaning to the player's exploration and reinforces the feeling of contributing towards a shared scientific goal.

---

## Immersion

Atlas Unwritten aims to create the illusion of participating in a believable scientific expedition.

The Atlas grows naturally over time. Specialists continue their research while the player is away from camp. Every discovery contributes towards understanding a living ecosystem rather than completing arbitrary objectives.

---

# Core Gameplay Loop

The gameplay loop is intentionally simple, allowing exploration and discovery to remain the focus throughout the experience.

1. Explore the environment.
2. Observe something unusual or interesting.
3. Enter Camera Mode.
4. Compose and capture a meaningful photograph.
5. Continue exploring or return to Base Camp.
6. Submit discoveries to the Atlas.
7. Specialists analyse submitted discoveries.
8. New research observations become available.
9. The player learns something new about the environment.
10. Curiosity encourages further exploration.

This loop reinforces the central philosophy that curiosity leads to discovery, discovery leads to understanding, and understanding encourages further exploration.

---

# Player Reward Structure

Atlas Unwritten uses a two-stage reward structure.

## Immediate Reward

Taking a photograph should always feel satisfying.

Strong visual feedback, responsive camera controls, animation, sound design, and presentation ensure that pressing the shutter is enjoyable regardless of whether the photograph is ultimately accepted for research.

---

## Delayed Reward

The true reward occurs after returning to Base Camp.

Accepted discoveries contribute towards ongoing scientific research. Specialists analyse submitted evidence over time, expanding Atlas entries with new observations, hypotheses, and conclusions.

Rather than rewarding players with points or experience, Atlas Unwritten rewards them with understanding. Players should leave each research update feeling that they have genuinely learned something new about the world.

---

# Player Character

The player assumes the role of a newly assigned expedition researcher.

The character intentionally remains mostly silent and unnamed, allowing players to project themselves into the role while maintaining a subtle personality through simple animations and environmental reactions.

The player is inexperienced compared to the expedition's specialists. This naturally explains why they are responsible for field exploration while more experienced researchers remain at Base Camp analysing discoveries.

The player is never portrayed as the hero of the expedition. Instead, they are one important contributor within a larger scientific team.

# Player Mechanics

Player mechanics are intentionally designed to remain simple and reliable. Movement should support exploration without becoming the primary focus of the experience.

The player should always feel in control of where they explore, allowing the environment and curiosity to drive progression rather than complex traversal mechanics.

---

## Movement

The movement system consists of:

- Walking
- Sprinting
- Jumping
- Climbing

Movement should feel responsive, natural and predictable.

Traversal is intended to support exploration rather than become a gameplay challenge. Players should spend their time observing the environment instead of mastering complicated movement systems.

Future traversal mechanics should only be considered if they improve exploration rather than distract from it.

---

# Camera System

The camera is the player's primary gameplay tool.

Rather than functioning as a weapon or collectible mechanic, it exists to document scientific discoveries made throughout the expedition.

Entering Camera Mode intentionally changes the player's mindset from movement to observation.

When entering Camera Mode:

- The player raises their camera through an animation.
- Perspective transitions from third-person exploration to first-person photography.
- Player movement is locked.
- Camera rotation remains available.
- Zoom controls allow players to frame their subject.
- A dedicated photography UI appears.
- The shutter animation and sound provide immediate feedback when a photograph is taken.

Locking movement encourages players to carefully choose their position before entering Camera Mode rather than constantly moving while photographing.

Good photographs begin with good observation.

---

# Photography Philosophy

Photography is the expedition's primary method of collecting evidence.

Unlike traditional photography games, Atlas Unwritten does not evaluate photographs using numerical scores.

Instead, every photograph is assessed according to one question:

> **Is this photograph scientifically useful?**

Examples include:

- Can the subject be clearly identified?
- Is enough of the subject visible?
- Does the image communicate useful scientific information?
- Is the subject obscured?
- Would another researcher be able to study this photograph?

Only photographs that meaningfully contribute to research become part of the expedition's official Atlas.

Poor photographs are not permanently stored within the Atlas, preventing unnecessary clutter while reinforcing that only meaningful discoveries become part of the expedition's official record.

---

# The Living Atlas

The Atlas is the central system of Atlas Unwritten.

It is not simply a photograph album or collectible tracker.

Instead, it represents the expedition's official scientific record and serves as the primary method through which discoveries, observations, and research are documented.

Every major gameplay system ultimately contributes towards expanding the Atlas.

The Atlas exists as a physical object located within Base Camp. Returning to camp gives the player an opportunity to review discoveries, submit new evidence, compare accepted photographs, and read specialist research.

Because the Atlas exists physically within the world, interacting with it reinforces the feeling of participating in an authentic scientific expedition.

---

# Atlas Entries

Each discoverable subject has a single Atlas entry.

Examples include:

- Plant species
- Wildlife
- Geological formations
- Fossils
- Archaeological discoveries

Every Atlas entry contains:

- Official research photograph
- Scientific description
- Research observations
- Research progress
- Specialist notes

Rather than collecting duplicate entries, players continue improving existing research through additional observations.

If a better photograph is captured later, the player may choose to replace the official research photograph without losing existing observations or research progress.

This encourages players to continually improve the quality of the expedition's scientific record.

---

# Research Observations

Discoveries are rarely understood immediately.

Instead, each Atlas entry grows over time as specialists analyse new evidence and compare observations.

A single Atlas entry may contain numerous research observations gathered across multiple expeditions.

Example:

## Desert Lily

Official Photograph

Research Progress: 50%

Research Observations

✓ Found growing in exposed sand.

✓ Found beneath sandstone overhangs.

☐ Pollination method unknown.

☐ Flowering behaviour not yet documented.

Rather than encouraging players to simply discover everything once, Atlas Unwritten rewards returning to familiar locations with new questions and deeper understanding.

---

# Research Progression

Research is a collaborative process.

When the player submits discoveries, expedition specialists begin analysing the available evidence.

After enough expedition time has passed, specialists expand Atlas entries by recording observations, proposing hypotheses, and identifying unanswered scientific questions.

Rather than directing the player through traditional quest objectives, research naturally guides future exploration.

Example:

_"The Desert Lily appears capable of surviving prolonged exposure to sunlight. Additional observations from sheltered environments may help explain this behaviour."_

The objective is not to tell players where to go.

The objective is to encourage curiosity.

Players should want to investigate because the world has become more interesting, not because they have been instructed to complete another task.

---

# Base Camp

Base Camp serves as the expedition's headquarters.

The camp has been established for several weeks before the player's arrival, giving the impression of an experienced research team already operating within the region.

The player returns regularly to:

- Review the Atlas.
- Submit discoveries.
- Read specialist observations.
- Monitor research progress.
- Continue expedition planning.

Returning to camp represents the second half of the gameplay loop and provides the delayed reward for successful exploration.

---

# Specialists

Each specialist represents a different scientific discipline.

Examples include:

- Botanist
- Geologist
- Archaeologist

Rather than acting as quest givers, specialists contribute their expertise by analysing discoveries and expanding Atlas entries through scientific observations.

Each specialist develops their own writing style, allowing players to gradually recognise individual personalities through research notes without requiring extensive dialogue or cinematic storytelling.

The specialists are collaborators, not mission providers.

Their purpose is to transform discoveries into understanding.

---

# NPC Philosophy

NPCs exist to reinforce the illusion of participating in a functioning scientific expedition.

Rather than implementing complex schedules or advanced artificial intelligence, specialists appear at different workstations whenever the player returns to Base Camp.

This simple system creates the impression that research continues while the player explores the environment.

Occasionally, specialists direct the player back towards the Atlas with comments such as:

_"I've added some notes to the Atlas."_

or

_"Your latest discovery raised an interesting question."_

This approach greatly reduces development complexity while maintaining immersion and supporting the core gameplay loop.

# Environment Design

The first vertical slice of Atlas Unwritten is set within a compact, handcrafted desert environment.

The environment is intentionally designed to prioritise quality over scale. Rather than creating a vast open world, development focuses on building a believable ecosystem filled with opportunities for observation, photography, and scientific discovery.

The desert should encourage exploration through natural curiosity rather than objective markers or navigation aids.

Potential areas include:

- Sand dunes
- Oasis
- Rocky cliffs
- Caves
- Ancient ruins
- Fossil sites
- Dry riverbeds
- Cactus fields
- Natural arches
- Abandoned expedition equipment

Every location should provide opportunities for environmental storytelling, unique photography, or scientific research.

The world itself should become the player's greatest reward.

---

# Environmental Storytelling

The environment should communicate its history without relying heavily on dialogue.

Players should naturally ask questions such as:

- Who built these ruins?
- Why has this river dried up?
- What caused these fossils to appear here?
- Why does this species only grow beneath rock formations?

The goal is not to answer every question immediately.

Instead, curiosity should encourage continued exploration and research.

Environmental storytelling should support the scientific tone of the expedition by encouraging players to observe rather than simply consume information.

---

# Visual Direction

Atlas Unwritten aims to achieve a realistic visual style while maintaining strong artistic composition.

The game takes inspiration from the visual appeal of New Pokémon Snap while presenting a more grounded and believable world.

Key visual goals include:

- Realistic lighting
- Natural colour palettes
- Atmospheric fog
- Dust particles
- Heat haze
- High-quality environmental assets
- Strong photographic composition
- Beautiful vistas that encourage players to stop and observe

The environment should consistently provide moments where players naturally want to raise the camera and document what they are seeing.

Every location should feel worthy of being photographed.

---

# Audio Direction

Audio should reinforce the feeling of exploring a remote environment.

The world should feel peaceful, isolated, and believable.

Examples include:

- Wind travelling across dunes.
- Distant wildlife.
- Sand shifting beneath footsteps.
- Subtle cave ambience.
- Flowing water near an oasis.
- Camera shutter and mechanical sounds.

Silence should be used intentionally.

Moments with little ambient sound can strengthen immersion and encourage players to focus on observing their surroundings.

---

# Technical Scope

Atlas Unwritten intentionally limits its scope in order to create a polished experience.

The project does not currently include:

- Combat
- Survival mechanics
- Crafting
- Inventory management
- Massive open worlds
- Dynamic weather systems
- Complex NPC artificial intelligence
- Multiplayer
- Skill trees
- Character progression systems

These exclusions are deliberate.

Every omitted feature allows additional development time to be invested into photography, exploration, research, and the Living Atlas.

The goal is depth rather than breadth.

---

# Minimum Viable Product (MVP)

The MVP represents the smallest complete version of Atlas Unwritten that successfully delivers the intended player experience.

The MVP includes:

- A handcrafted desert environment.
- Third-person exploration.
- Basic movement.
- Camera Mode.
- Scientific photograph evaluation.
- Living Atlas.
- Research progression.
- Base Camp.
- Specialist observations.
- Saving and loading progression.
- Environmental storytelling.
- A complete gameplay loop from exploration to research.

Every feature included within the MVP directly supports the game's core philosophy.

Additional mechanics should only be considered after the MVP has been completed and polished.

---

# Future Considerations

The following ideas are intentionally excluded from the MVP.

They are not promises or planned features, but opportunities that may be explored once the core experience has been completed.

Examples include:

- Additional expedition environments.
- Seasonal environmental variations.
- More specialist disciplines.
- Rare environmental events.
- Expanded wildlife behaviours.
- Advanced photography equipment.
- Deeper environmental interactions.
- More complex expedition management.

Features should only move from this section into the main design once they have been deliberately committed to development.

---

# Completion Philosophy

Atlas Unwritten is designed around understanding rather than collection.

Discovering a subject represents the beginning of research rather than its conclusion.

An Atlas entry becomes complete when the expedition has gathered sufficient evidence for specialists to confidently document their understanding of the subject.

However, scientific understanding is never truly final.

Future observations, unusual environmental conditions, or additional expeditions may expand existing knowledge even after an entry has been considered complete.

Players should finish Atlas Unwritten feeling that they have genuinely helped humanity understand an unexplored environment rather than simply completing a checklist.

The final reward is not a percentage.

It is understanding.

---

# Design Principles

The following principles should guide every future design decision.

If a proposed feature does not reinforce one or more of these principles, its inclusion should be carefully reconsidered.

- Curiosity should always be rewarded.
- Observation is more valuable than speed.
- Photography creates knowledge.
- Research gives discoveries meaning.
- Specialists are collaborators, not quest givers.
- The Atlas is the heart of the experience.
- Simplicity is preferable to unnecessary complexity.
- Quality is always prioritised over quantity.
- Every player action should have immediate feedback.
- Every meaningful discovery should have lasting significance.

These principles exist to preserve the identity of Atlas Unwritten throughout development.

---

# Versioning

This document represents Version 1.0 of the Atlas Unwritten Game Design Document.

The GDD is intended to evolve alongside development. New ideas should not immediately become committed features. Instead, they should first be evaluated against the project's core philosophy and Minimum Viable Product.

The purpose of this document is not to describe every possible idea, but to define the game Atlas Unwritten is committed to becoming.
