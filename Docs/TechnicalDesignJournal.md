# Technical Design Journal

> **Purpose:** This document records the technical and architectural decisions made throughout the development of Atlas Unwritten. Unlike the Game Design Document, which describes the intended player experience, this journal explains how that experience will be supported through software architecture, engineering principles, and implementation decisions.
>
> The purpose of this journal is not simply to record what was built, but to explain why particular technical decisions were made, what alternatives were considered, and the trade-offs involved. As development progresses, this document will evolve alongside the project.

---

# Engineering Philosophy

Atlas Unwritten is being developed with the mindset of creating maintainable, scalable, and well-documented software rather than simply achieving working gameplay.

Every engineering decision should aim to improve one or more of the following:

- Maintainability
- Readability
- Separation of responsibilities
- Scalability
- Testability
- Ease of iteration

Whenever multiple technical solutions are available, preference should be given to the solution that produces cleaner architecture rather than the shortest implementation.

---

# Engineering Principles

These principles apply throughout the entire project and should guide every future technical decision.

## Principle 001 — Single Responsibility

Every system should have one clearly defined responsibility.

Systems should communicate with one another, but should avoid becoming responsible for multiple unrelated areas of gameplay.

Example:

The Camera captures photographs.

The Atlas manages research.

The Player manages movement.

Each system has a clearly defined purpose.

---

## Principle 002 — Data Driven Design

Gameplay data should be separated from gameplay logic whenever practical.

Rules describing research subjects, Atlas entries, and other configurable content should exist as editable Unreal Engine assets rather than hard-coded C++ values.

This allows designers to modify gameplay content without rewriting code and improves long-term maintainability.

---

## Principle 003 — Systems Before Features

Core systems should be designed before gameplay features are implemented.

A strong architectural foundation reduces redesign later in development and allows new mechanics to build upon existing systems rather than replacing them.

---

## Principle 004 — Simplicity Before Complexity

Whenever two technical solutions achieve the same gameplay outcome, preference should be given to the simpler architecture.

Complexity should only be introduced when it provides a measurable long-term benefit.

---

## Principle 005 — Build for Extension

Systems should be designed so that future content can be added without requiring major architectural changes.

Adding a new plant species should primarily involve creating new data rather than rewriting existing gameplay systems.

---

# Architecture Decisions

The following decisions describe the high-level architecture of Atlas Unwritten.

---

## Decision 000 — The Atlas is the Core System

### Decision

The Atlas is the central gameplay system rather than a passive collection menu.

### Reason

Every major mechanic within Atlas Unwritten either contributes to or is driven by the Atlas.

Photography provides research evidence.

Specialists analyse discoveries.

Research observations expand scientific knowledge.

Player progression is represented through the expedition's growing understanding of the environment.

This keeps exploration, progression, and narrative unified around one central system.

### Trade-offs

The Atlas requires considerably more planning than a traditional collectibles menu.

Many gameplay systems become dependent upon it, increasing its architectural importance.

In return, every major mechanic reinforces the same core gameplay fantasy: contributing towards a living scientific expedition.

---

## Decision 001 — Atlas Ownership

### Decision

The Atlas exists as an independent gameplay system and is not owned by the Player.

### Reason

The Player is responsible for movement, interaction, and input.

The Atlas is responsible for research progression, accepted discoveries, observations, specialist analysis, and persistent expedition knowledge.

Separating these responsibilities prevents the Player class from becoming overloaded while allowing the Atlas to evolve independently.

### Trade-offs

Communication between gameplay systems becomes more important.

However, the resulting architecture is significantly easier to maintain and extend.

## Decision 002 — Photo Result Submission

### Decision

The Camera is responsible for capturing photographs and submitting the resulting photo data to the Atlas Manager.

### Reason

Capturing a photograph and deciding what to do with it are separate responsibilities.

The Camera should only concern itself with producing accurate photo data.

The Atlas Manager determines whether the photograph contributes towards research, updates Atlas entries, stores accepted photographs, and triggers any research progression.

Keeping these responsibilities separate produces a cleaner and more maintainable architecture.

### Trade-offs

The Camera now depends upon the Atlas Manager for processing.

However, the Camera itself remains simple and focused solely on photography.

---

## Decision 003 — Atlas Validates Research Photos

### Decision

The Atlas Manager is responsible for determining whether a photograph is scientifically useful.

### Reason

Research progression belongs to the Atlas rather than the Camera.

The Camera records evidence.

The Atlas evaluates evidence.

This separation allows research rules to evolve independently from photography mechanics.

### Trade-offs

The Atlas Manager requires sufficient information to evaluate photographs correctly.

This increases the importance of designing a robust photo data structure.

---

## Decision 004 — Separate Photo Requirements from Research Text

### Decision

Research requirements and research content are stored independently.

### Reason

Photo requirements remain relatively stable throughout development.

Research text, specialist observations, hypotheses, and conclusions evolve as the player contributes new discoveries.

Separating these systems prevents gameplay validation from becoming coupled with narrative progression.

### Trade-offs

Additional data structures are required.

However, both systems become significantly easier to extend independently.

---

## Decision 005 — Data Driven Research Subjects

### Decision

Research subjects should be defined using editable Unreal Engine Data Assets rather than hard-coded C++ values.

### Reason

Each research subject can define its own photography requirements, identifiers, and gameplay values without requiring code modifications.

Adding new discoveries becomes primarily a content creation task rather than a programming task.

This also allows balancing and iteration without recompiling the project.

### Trade-offs

Requires additional editor asset management.

However, long-term scalability is significantly improved.

---

## Decision 006 — Photo Data is a Value Object

### Decision

Photographs are represented by structured data rather than gameplay objects containing behaviour.

### Reason

A photograph represents evidence collected during gameplay.

The photograph itself should not contain gameplay logic.

Instead, it stores information describing the capture, allowing other gameplay systems to interpret and process the data.

Example information may include:

- Image reference
- Subject identifier
- Camera transform
- Visibility information
- Capture timestamp
- Evaluation values

### Trade-offs

Gameplay behaviour becomes distributed across multiple systems.

However, each system remains focused on its own responsibility.

---

## Decision 007 — Player Camera and Camera Separation

### Decision

The Player Camera and the Camera are treated as separate gameplay systems.

### Reason

The Player Camera exists purely to present the third-person gameplay experience.

The Camera is an in-world gameplay tool responsible for capturing photographs.

Separating both the terminology and implementation reduces confusion during development and keeps each system focused on its intended role.

### Trade-offs

Additional classes and terminology are introduced.

However, the resulting architecture is considerably clearer.

---

## Decision 008 — Environment Before Gameplay Systems

### Decision

Greybox environments should be developed before implementing major gameplay systems.

### Reason

The environment provides meaningful context for testing movement, exploration, photography, player flow, and environmental composition.

Developing gameplay systems without a representative environment increases the likelihood of redesign later.

### Trade-offs

Gameplay systems begin slightly later.

However, testing occurs under realistic gameplay conditions from the earliest stages of development.

## Decision 009 — Unreal Engine 5.6

### Decision

Atlas Unwritten will use Unreal Engine 5.6.

### Reason

Unreal Engine 5.6 is currently more stable on the development machine than newer versions. Unreal Engine 5.7 caused GPU crashes during startup, making it unsuitable for regular development.

---

# Development Principles

The following principles guide the overall development process rather than individual gameplay systems.

---

## Principle 006 — Separate Vision from Scope

The long-term vision of Atlas Unwritten extends beyond the initial desert expedition.

However, development focuses exclusively on completing one polished vertical slice before expanding the project's scope.

Documentation should distinguish between the overall vision and the currently committed scope.

---

## Principle 007 — Commitments Before Considerations

Only features that are actively committed to development should appear within the main Game Design Document.

Interesting ideas that are not essential to the current project belong within Future Considerations until they are intentionally approved for implementation.

This prevents scope creep while preserving valuable ideas.

---

## Principle 008 — Intentional Development

Every milestone, commit, document, and technical decision should contribute towards telling the story of the project's evolution.

The repository should demonstrate not only what was built, but why each decision was made.

Future readers should be able to understand the project's progression without relying on external explanations.

---

## Principle 009 — Immediate Feedback, Lasting Significance

Every meaningful player action should produce immediate feedback while contributing towards long-term progression.

This principle applies equally to gameplay systems and technical implementation.

Immediate responsiveness improves game feel.

Persistent progression provides lasting player motivation.

Engineering decisions should support both.

# Future Architecture Considerations

The following ideas are intentionally recorded for future evaluation.

They are not committed architectural decisions and should not influence the current implementation until the project's core systems have been completed.

Potential future considerations include:

- Event-driven communication between gameplay systems.
- Additional observation systems beyond photography.
- Modular specialist behaviours.
- More advanced save versioning.
- Expanded data-driven research categories.
- Additional expedition environments.
- Improved tooling for creating Atlas content.

These ideas should only be adopted if they improve maintainability or simplify future development.

---

# Architecture Review Process

Every significant technical decision should be evaluated against the following questions before implementation.

## Responsibility

Does this system have one clearly defined responsibility?

---

## Coupling

Does this change increase unnecessary dependencies between systems?

---

## Scalability

Can this system support future content without requiring major redesign?

---

## Maintainability

Will future developers (or future versions of myself) easily understand this implementation?

---

## Simplicity

Is this the simplest architecture capable of achieving the desired behaviour?

---

## Testability

Can this system be tested independently from unrelated gameplay systems?

---

# Engineering Goals

Atlas Unwritten is intended to demonstrate professional software engineering practices alongside gameplay programming.

Every system should strive to achieve the following goals.

## Clean Responsibilities

Each gameplay system should own one clearly defined area of responsibility.

Large "God Classes" should be avoided.

---

## Data Driven Design

Gameplay content should primarily be created through editable assets rather than repeated code modifications.

---

## Modular Systems

Gameplay systems should communicate through clearly defined interfaces and events rather than tightly coupling themselves together.

Systems should react to gameplay changes instead of controlling one another whenever practical.

---

## Readable Code

Code should be written for future maintainability rather than cleverness.

Clear naming, consistent formatting, and straightforward logic should always be preferred.

---

## Incremental Development

Large systems should be developed through small, testable milestones.

Each milestone should leave the project in a working state before moving to the next feature.

---

## Documentation First

Significant architectural decisions should be documented before implementation whenever practical.

The Technical Design Journal should explain why a solution exists rather than simply describing what was implemented.

---

## Versioning Philosophy

This journal represents Version 1.0 of the Atlas Unwritten Technical Design Journal.

The document is expected to evolve throughout development.

New decisions should only be added once they have been consciously made during implementation.

The purpose of this journal is not to predict future architecture, but to preserve the reasoning behind the architecture that exists.

As the project grows, this document should become a historical record of Atlas Unwritten's engineering evolution.
