//======================================
//  TestDisplay
//  Created on: 20.01.2026 23:35:40
//  Author: Vova43
//======================================
namespace tests {
    public class TestDisplay : Test {
        public override void main(string[] args) {
            platform.Display display = new platform.Display(true);
            while (!display.isCloseRequested) {
                display.update();
            }
            display.destroy();
        }
    }
}
