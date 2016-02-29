using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CookieClicker
{
    abstract class GameObject
    {
        protected Vector2D position;
        protected Image sprite;
        protected List<Image> animationFrames;
        protected float currentFrameIndex;
        private float scaleFactor;
        

        public GameObject(string imagePath, Vector2D startPosition, float scaleFactor)
        {
            string[] imagePaths = imagePath.Split(';');
            this.position = startPosition;
            this.animationFrames = new List<Image>();
            this.scaleFactor = scaleFactor;
            foreach (string path in imagePaths)
            {
                animationFrames.Add(Image.FromFile(path));
            }
            this.sprite = this.animationFrames[0];
        }
        public virtual void Draw(Graphics dc)
        {
            
            dc.DrawImage(sprite, position.X,position.Y,sprite.Width*scaleFactor,sprite.Height*scaleFactor);
            
        }
        public virtual void update(float fps)
        {
           
        }
        public virtual void UpdateAnimation(float fps)
        {
            float factor = 1 / fps;

            currentFrameIndex += factor * animationFrames.Count;

            if (currentFrameIndex >= animationFrames.Count)
            {
                currentFrameIndex = 0;
            }
            sprite = animationFrames[(int)currentFrameIndex];
        }
        

        public Vector2D Position
        {
            get
            {
                return position;
            }

            set
            {
                position = value;
            }
        }
    }
}
