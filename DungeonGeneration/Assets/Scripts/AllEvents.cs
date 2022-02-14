using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SDD.Events;

#region GameManager Events
public class GameInitLevelEvent : SDD.Events.Event
{
}
public class GameMenuEvent : SDD.Events.Event
{
}
public class GamePlayEvent : SDD.Events.Event
{
}
public class GamePauseEvent : SDD.Events.Event
{
}
public class GameResumeEvent : SDD.Events.Event
{
}
public class GameOverEvent : SDD.Events.Event
{
}
public class GameVictoryEvent : SDD.Events.Event
{
}

public class GameStatisticsChangedEvent : SDD.Events.Event
{
    public float eBestScore { get; set; }
    public int eScore { get; set; }
    public int eNLives { get; set; }
    public float eSpeedDifficultyFactor { get; set; }
}
#endregion

#region MenuManager Events
public class EscapeButtonClickedEvent : SDD.Events.Event
{
}
public class PlayButtonClickedEvent : SDD.Events.Event
{
}
public class ResumeButtonClickedEvent : SDD.Events.Event
{
}
public class MainMenuButtonClickedEvent : SDD.Events.Event
{
}

public class QuitButtonClickedEvent : SDD.Events.Event
{ }
#endregion

#region Score Event
public class ScoreHasBeenGainedEvent : SDD.Events.Event
{
    public int eScore;
}
#endregion

public class LevelHasBeenInitializedEvent : SDD.Events.Event
{
    public Transform ePLayerSpawnPoint;
}

public class PlayerHasBeenKilledEvent : SDD.Events.Event
{
}
