# Assignment6

In this assignment, we were tasked with designing a "workflow engine" that takes a workflow object and runs it. A workflow is a series of steps or activities. This assignment should include the following:

1) A WorkFlowEngline class, that has one method called Run() (which takes a workflow.

2) The Run() method, should iterate over each activity in the workflow, and run it bases on its specified order within the object.

3) A workflow must consist of a name, and contain any amount of activities in the order.

4) The workflows must be extensible, meaning new activities can be created without impacting existing activities.

5) The application must account for nulls and needs validation, throwing a ArgumentNullException is fine with an error message describing the error, or just not allowing it to crash (return).

6) We should represent the concept of an activity using an interface, with each activity having a method called Execute() and an order.

# Requirements

- Unit tests
    100% code coverage
    All tests pass
- Clean project structure
    Separate files into folders when it makes sense
- Follows coding standards in syllabus
- README.md
- Passes my unit tests that are unknown!
    Nulls & validation
-Submitted via GitHub
