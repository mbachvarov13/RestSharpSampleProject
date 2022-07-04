Feature: Posts feature

Scenario: Create a new POST
	Given I am creating a new POST using <id> <title> and <author>
Examples:
	| id | title     | author     |
	| 6  | testTitle | testAuthor |