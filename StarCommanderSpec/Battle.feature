﻿Feature: Battle
	I want to be told the sum of the fleets who survive

@myBatttle
Scenario: Execute Battle
	Given I have entered 6 Fleets into the BattleField
	When I call startBattle
	Then the result should be 1 Fleet with working ships greater than zero
