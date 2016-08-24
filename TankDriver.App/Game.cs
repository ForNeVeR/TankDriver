using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using TankDriver.Logic;

namespace TankDriver
{
	/// <summary>
	/// This is the main type for your game
	/// </summary>
	public class Game : Microsoft.Xna.Framework.Game
	{
		/// <summary>
		/// Graphics device manager.
		/// </summary>
		private readonly GraphicsDeviceManager _graphics;

		/// <summary>
		/// Object for performing batch sprite operations.
		/// </summary>
		private SpriteBatch _spriteBatch;

		/// <summary>
		/// Player tank.
		/// </summary>
		private Tank _tank;

		/// <summary>
		/// Game constructor.
		/// </summary>
		public Game()
		{
			_graphics = new GraphicsDeviceManager(this) {PreferMultiSampling = true};
			Content.RootDirectory = "Content";
		}

		/// <summary>
		/// Allows the game to perform any initialization it needs to before starting to run.
		/// This is where it can query for any required services and load any non-graphic
		/// related content.  Calling base.Initialize will enumerate through any components
		/// and initialize them as well.
		/// </summary>
		protected override void Initialize()
		{
			_tank = new Tank(50.0, 50.0, 0.0);

			base.Initialize();
		}

		/// <summary>
		/// LoadContent will be called once per game and is the place to load
		/// all of your content.
		/// </summary>
		protected override void LoadContent()
		{
			// Create a new SpriteBatch, which can be used to draw textures.
			_spriteBatch = new SpriteBatch(GraphicsDevice);

			var textureStorage = new TextureStorage(Content);
			_tank.GetModel().LoadTextures(textureStorage);
		}

		/// <summary>
		/// UnloadContent will be called once per game and is the place to unload
		/// all content.
		/// </summary>
		protected override void UnloadContent()
		{
		}

		/// <summary>
		/// Allows the game to run logic such as updating the world,
		/// checking for collisions, gathering input, and playing audio.
		/// </summary>
		/// <param name="gameTime">Provides a snapshot of timing values.</param>
		protected override void Update(GameTime gameTime)
		{
			var keyboardState = Keyboard.GetState();
			if (keyboardState.IsKeyDown(Keys.W))
			{
				_tank.Accelerate();
			}
			if (keyboardState.IsKeyDown(Keys.S))
			{
				_tank.Decelerate();
			}

			bool turning = false;
			if (keyboardState.IsKeyDown(Keys.A))
			{
				_tank.TurnRight();
				turning = true;
			}
			if (keyboardState.IsKeyDown(Keys.D))
			{
				_tank.TurnLeft();
				turning = !turning;
			}
			if (!turning)
			{
				_tank.StopTurning();
			}

			var mouseState = Mouse.GetState();
			if (mouseState.LeftButton == ButtonState.Pressed) {
				_tank.Shoot ();
			}

			_tank.SetTarget(mouseState.X, mouseState.Y);

			_tank.UpdatePosition(gameTime.ElapsedGameTime);

			base.Update(gameTime);
		}

		/// <summary>
		/// This is called when the game should draw itself.
		/// </summary>
		/// <param name="gameTime">Provides a snapshot of timing values.</param>
		protected override void Draw(GameTime gameTime)
		{
			_spriteBatch.Begin();

			// Clear screen:
			GraphicsDevice.Clear(Color.CornflowerBlue);

			// Render the tank:
			_tank.GetModel().Render(_spriteBatch);

			base.Draw(gameTime);

			_spriteBatch.End();
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
			if (disposing)
			{
				_graphics.Dispose();
			}
		}
	}
}
