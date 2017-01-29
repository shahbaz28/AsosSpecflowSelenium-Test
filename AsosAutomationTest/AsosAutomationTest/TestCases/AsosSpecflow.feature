Feature: Use the website to find shirts

So that I can order a shirt

As a customer

I want to be able to find t shirts

And I want to be able to find t shirts for females


Scenario: Search for t shirts

Given I want to order a shirt

When i search for purple t shirts

Then I should see some purple t shirts


Scenario:  Search from female t shirts

Given I want to order a shirt

When i search for purple t shirts

And I filetr to female

Then I see t shirts for female


