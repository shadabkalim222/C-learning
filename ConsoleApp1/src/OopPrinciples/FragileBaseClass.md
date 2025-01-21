Fragile Base Class Problem and why you should use composition over inheritance.

The Fragile Base Class Problem is a software design issue that arises in Object-Oriented programming when changes made to a base class can inadvertently break the functionality of dervied classes. This problem occurs due to the tight coupling between base and derived classes is inheritance heirarchies.

1) Inheritance Coupling: Inheritance creates a strong coupling between the base class (superclass) and derived classes (subclasses). Any changes made to the base class can potentitally affect the behavior of all dervied classes.
2) Limited Extensibility: The Fragile Base Class Problem limits the extensibility of software systems, as modifications to the base class can become increasingly risky and costly over time. Devvelopers may avoid making necessary changes due to the fear of breaking existing funcitonality - Brittle Software.

Mitigation Strategies:
To mitigate the above problem, software developers can use design principles such as open/close principle and dependency inversion principle, as well as design patterns like composition over inheritance. These approaches promote loose coupling, encapsulation, and modular design, reducing the impac tof changes in base class.