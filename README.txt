Blazor Menu Task

This repository contains the implementation of a blazor menu component. The project is structured into two main parts: the component project and the demo project. This README provides a detailed description of what has been implemented and the rationale behind the chosen approach.

# Project Structure

The solution contains two project

1. MenuComponent
A Razor Class Library that contains all necessary information for the control, including implementation, models, and CSS files. The MenuItem_Model c# class is actually named MenuItem, but for convenience, an alias is added in _Imports.razor file.

2. MenuComponent.Demo
A Blazor application that demonstrates the usage of the Menu control in various real-world scenarios. These examples include different themes and complex nesting structures to showcase the component's capabilities.

# Implementation Description

The MenuComponent project contains the component and its dependencies. The new MenuControl is split into three parts: Menu, MenuItem, and a model class MenuItem_Model.

### Menu
The Menu component is the main control responsible for the general settings. It expects a collection of MenuItem_Model objects, where each object represents a part of the menu that should be displayed. By separating the visualisation achieved infinite nesting by recursively creating child items and also this improves the readability and scalability of the code.

### MenuItem
Each MenuItem contains an instance of MenuItem_Model. This model provides information about the text of the element and all of its children. The MenuItem component uses this information to display each element and its children correctly.
Two events are hooked to each MenuItem:
onmouseover: Displays the submenu when the mouse pointer is over the menu item.
onmouseout: Hides the submenu when the mouse pointer leaves the menu item.

These events trigger changes to a dynamic style property, adding different CSS classes to each submenu item to control their visibility and position (below or to the right of their parent/submenu).