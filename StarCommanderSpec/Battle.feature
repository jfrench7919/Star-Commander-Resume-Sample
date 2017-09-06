Feature: Battle
	I want to be told the sum of the fleets who survive

@myBatttle
Scenario: Exicute Battle
	Given I have entered 6 Fleets into the BattleField
	When I call startBattle
	Then the result should be 1 Fleet with health greater than zero
