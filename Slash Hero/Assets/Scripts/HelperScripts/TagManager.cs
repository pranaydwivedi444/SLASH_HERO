using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  static class TagManager 
{
    public static string Player_Tag = "Player";
    public static string GROUND_TAG = "Ground";
    public static string TREE_1_TAG = "Tree1";
    public static string TREE_2_TAG = "Tree2";
    public static string ENEMY_TAG = "Enemy";
    public static string OBSTACLE_TAG = "Obstacle";
    public static string HEALTH_TAG = "Health";
    public static string GAMEPLAY_CONTROLLER_TAG = "GameplayController";
    public static string HEALTH_BAR_HOLDER_TAG = "HealthBarHolder";

    public static string JUMP_BUTTON = "Jump";
    //Animations
    public static string  JUMP_ANIMATION_PARAMERTER = "jump";
    public static string ATTACK_ANIMATION_PARAMERTER = "Attack";
    public static string RUNNING_ANIMATION_PARAMERTER = "Running";
    public static string DOUBLE_JUMP_ANIMATION_PARAMERTER = "DoubleJump";
    public static string JUMP_ATTACK_ANIMATION_PARAMERTER = "JumpAttack";
    public static string DEATH_ANIMATION_PARAMERTER = "Death";
    public static string ATTACK_TRIGGER_PARAMERTER = "Attack Trigger ";

    // animation names
    public static string RUNNING_ANIMATION_NAME = "Running";
    public static string RUNNING_ATTACK_ANIMATION_NAME = "RunningAttack";
    public static string JUMP_ANIMATION_NAME = "jump";
    public static string JUMP_ATTACK_ANIMATION_NAME = "Jump attack";
    public static string FALL_ANIMATION_NAME = "Fall";
    public static string DOUBLE_JUMP_ANIMATION_NAME = "Double Jump";
    public static string DEATH_ANIMATION_NAME = "Death";

    // scene names
    public static string GAMEPLAY_SCENE_NAME = "Gameplay";
    public static string MAIN_MENU_SCENE_NAME = "MainMenu";

    // character names (in gameplay scene)
    public static string NORMAL_PLAYER = "Slash Panda Normal";
    public static string RED_PLAYER = "Slash Panda Red";
    public static string BLUE_PLAYER = "Slash Panda Blue";

    // Game data
    public static string CHARACTER_DATA = "Character";
    public static string SELECTED_CHARACTER_DATA = "Selected Character";

    public static string HIGHSCORE_DATA = "Highscore";

    public static string MUSIC_DATA = "Music";

    // 0 data not initialized, 1 data initialized
    public static string DATA_INITIALIZED = "Data Initialized";

}
