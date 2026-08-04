# Demo WPF application
## Goal
- Create a simple WPF application for demonstration purposes
- Add sublte bugs and delays to showcase dedicated AI agents, like the debug and profiler agents, in action
- Keep it simple and easy to understand
- Keep code readable and maintainable

## App context
- The application is called "Mechastore" and is a simple WPF application where users can buy robots.
- Users can 'buy' a robot which creates a sale order, and then a production order will be created for the robot to be built once the sale order is approved.
- The application will be used during a GitHub Copilot workshop. The people following work with their own WPF ERP application.
- During the workshop, we will show some GitHub Copilot features, like the debug and profiler agents, to help them with their own WPF ERP application.

## Features
- Use WPF naming conventions.
- Use a MVVM architecture for better separation of concerns
- The following in-memory-backend should be implemented:
  - Sale orders (robots that users want to buy, each sale line would be a robot)
  - Production orders (robots that are being built, each line would be a component of the robot sold)
- The following UI components should be implemented:
  - List of robots available for sale screen called 'Catalogue' (with a 'buy now' button)
  - Sale order list screen called 'Sales' (list of sales with a 'view details' button)
  - Sale order details (details of the robot that users have bought)
  - Production order list screen called 'Production' (list of robots that are being built with a 'view details' button)
  - Production order details (details of the robot that is being built)
- CRUD operations for sale orders and production orders
- For simplicity, users can only buy one robot at a time, and the sale order will be created with one line for the robot that is being bought.

## Looks
- The application should have a simple and clean look, with a modern design.
- The robots should have a preview image, a name, a description, and a price.
- The sale order list should show the robot name, the price, and the status of the sale order (e.g. "Pending", "Approved", "Rejected").
- The production order list should show the robot name, the status of the production order (e.g. "In Progress", "Completed"), and the estimated completion date.

## Additional features for demonstrating AI agents
- Add in a placeholder method when the status of a sales order is updated to "Approved" to automatically create a production order for the sale order. This will be a placeholder method that can be implemented later live with AI.
- Add in a placeholder file for Unit tests for demonstrating the testing agent. This will be a placeholder file that can be implemented later live with AI.
- Introduce a small bug to demonstrate the debug agent. This will be solved later live with AI.
- Introduce a small performance issue to demonstrate the profiler agent. This will be solved later live with AI.